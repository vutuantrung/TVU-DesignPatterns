using NUnit.Framework;
using Prototype.Enum;
using Prototype.PersonService;
using Prototype.PersonSpace;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestFixture]
    class PrototypeTests
    {
        [Test]
        public void test_copy()
        {
            string personName = "test_name";
            string personId = "person_id";

            string adrCountry = "country_test";
            string adrCity = "city_test";
            string adrDistrict = "district_test";
            string adrStreet = "street_test";
            int adrNumber = 202;

            string perCompany = "company_test";
            string perJob = "job_test";
            string perSector = "sector_test";

            EnumRelationship personRelationship = EnumRelationship.Single;

            #region Original person
            Person personOriginal = new Person( personName, personId );

            PersonServiceDirector director = new PersonServiceDirector();
            director.Person = personOriginal;
            director.SetPersonAdress( country: adrCountry, city: adrCity, district: adrDistrict, street: adrStreet, number: adrNumber );
            director.SetPersonJob( company: perCompany, job: perJob, sector: perSector );
            director.SetPersonRelationship( relationship: personRelationship );
            #endregion

            #region Orignial person
            Assert.That( personOriginal.Name == personName );
            Assert.That( personOriginal.PersonID == personId );

            Assert.That( personOriginal.PersonJob.Company == perCompany );
            Assert.That( personOriginal.PersonJob.Job == perJob );
            Assert.That( personOriginal.PersonJob.Sector == perSector );

            Assert.That( personOriginal.PersonAdress.Country == adrCountry );
            Assert.That( personOriginal.PersonAdress.City == adrCity );
            Assert.That( personOriginal.PersonAdress.District == adrDistrict );
            Assert.That( personOriginal.PersonAdress.Street == adrStreet );
            Assert.That( personOriginal.PersonAdress.Number == adrNumber );

            Assert.That( personOriginal.RelationShip.Relationship == personRelationship );
            #endregion

            #region Shallow copied person
            Person personShallowCopied = personOriginal.ShallowCopy();

            Assert.That( personShallowCopied.Name == personName );
            Assert.That( personShallowCopied.PersonID == personId );

            Assert.That( personShallowCopied.PersonJob.Company == perCompany );
            Assert.That( personShallowCopied.PersonJob.Job == perJob );
            Assert.That( personShallowCopied.PersonJob.Sector == perSector );

            Assert.That( personShallowCopied.PersonAdress.Country == adrCountry );
            Assert.That( personShallowCopied.PersonAdress.City == adrCity );
            Assert.That( personShallowCopied.PersonAdress.District == adrDistrict );
            Assert.That( personShallowCopied.PersonAdress.Street == adrStreet );
            Assert.That( personShallowCopied.PersonAdress.Number == adrNumber );

            Assert.That( personShallowCopied.RelationShip.Relationship == personRelationship );
            #endregion


            #region Deep copied person
            Person personDeepCopied = personOriginal.DeepCopyV1();

            Assert.That( personDeepCopied.Name == personName );
            Assert.That( personDeepCopied.PersonID == personId );

            Assert.That( personDeepCopied.PersonJob.Company == perCompany );
            Assert.That( personDeepCopied.PersonJob.Job == perJob );
            Assert.That( personDeepCopied.PersonJob.Sector == perSector );

            Assert.That( personDeepCopied.PersonAdress.Country == adrCountry );
            Assert.That( personDeepCopied.PersonAdress.City == adrCity );
            Assert.That( personDeepCopied.PersonAdress.District == adrDistrict );
            Assert.That( personDeepCopied.PersonAdress.Street == adrStreet );
            Assert.That( personDeepCopied.PersonAdress.Number == adrNumber );

            Assert.That( personDeepCopied.RelationShip.Relationship == personRelationship );
            #endregion
        }

        [Test]
        public void test_copy_changing_original_v1()
        {
            string personName = "test_name";
            string personId = "person_id";

            string adrCountry = "country_test";
            string adrCity = "city_test";
            string adrDistrict = "district_test";
            string adrStreet = "street_test";
            int adrNumber = 202;

            string perCompany = "company_test";
            string perJob = "job_test";
            string perSector = "sector_test";

            EnumRelationship personRelationship = EnumRelationship.Single;

            #region Original person
            Person personOriginal = new Person( personName, personId );

            PersonServiceDirector director = new PersonServiceDirector();
            director.Person = personOriginal;
            director.SetPersonAdress( country: adrCountry, city: adrCity, district: adrDistrict, street: adrStreet, number: adrNumber );
            director.SetPersonJob( company: perCompany, job: perJob, sector: perSector );
            director.SetPersonRelationship( relationship: personRelationship );
            #endregion

            #region Copy person
            Person personShallowCopied = personOriginal.ShallowCopy();
            Person personDeepCopied = personOriginal.DeepCopyV1();
            #endregion


            #region Change original person data
            string changedPersonName = "test_name_changed";
            string changedPersonId = "person_id_changed";

            string changedAdrCountry = "country_test_changed";
            string changedAdrCity = "city_test_changed";
            string changedAdrDistrict = "district_test_changed";
            string changedAdrStreet = "street_test_changed";
            int changedAdrNumber = 202;

            string changedPerCompany = "company_test_changed";
            string changedPerJob = "job_test_changed";
            string changedPerSector = "sector_test_changed";

            EnumRelationship changedPersonRelationship = EnumRelationship.Married;

            personOriginal.Name = changedPersonName;
            personOriginal.PersonID = changedPersonId;

            director.SetPersonAdress( country: changedAdrCountry, city: changedAdrCity, district: changedAdrDistrict, street: changedAdrStreet, number: changedAdrNumber );
            director.SetPersonJob( company: changedPerCompany, job: changedPerJob, sector: changedPerSector );
            director.SetPersonRelationship( relationship: changedPersonRelationship );
            #endregion

            #region Original person
            Assert.That( personOriginal.Name == changedPersonName );
            Assert.That( personOriginal.PersonID == changedPersonId );

            Assert.That( personOriginal.PersonJob.Company == changedPerCompany );
            Assert.That( personOriginal.PersonJob.Job == changedPerJob );
            Assert.That( personOriginal.PersonJob.Sector == changedPerSector );

            Assert.That( personOriginal.PersonAdress.Country == changedAdrCountry );
            Assert.That( personOriginal.PersonAdress.City == changedAdrCity );
            Assert.That( personOriginal.PersonAdress.District == changedAdrDistrict );
            Assert.That( personOriginal.PersonAdress.Street == changedAdrStreet );
            Assert.That( personOriginal.PersonAdress.Number == changedAdrNumber );

            Assert.That( personOriginal.RelationShip.Relationship == changedPersonRelationship );
            #endregion

            #region Shallow copied person
            Assert.That( personShallowCopied.Name == personName );
            Assert.That( personShallowCopied.PersonID == personId );

            Assert.That( personShallowCopied.PersonJob.Company == perCompany );
            Assert.That( personShallowCopied.PersonJob.Job == perJob );
            Assert.That( personShallowCopied.PersonJob.Sector == perSector );

            Assert.That( personShallowCopied.PersonAdress.Country == adrCountry );
            Assert.That( personShallowCopied.PersonAdress.City == adrCity );
            Assert.That( personShallowCopied.PersonAdress.District == adrDistrict );
            Assert.That( personShallowCopied.PersonAdress.Street == adrStreet );
            Assert.That( personShallowCopied.PersonAdress.Number == adrNumber );

            Assert.That( personShallowCopied.RelationShip.Relationship == personRelationship );
            #endregion


            #region Deep copied person
            Assert.That( personDeepCopied.Name == personName );
            Assert.That( personDeepCopied.PersonID == personId );

            Assert.That( personDeepCopied.PersonJob.Company == perCompany );
            Assert.That( personDeepCopied.PersonJob.Job == perJob );
            Assert.That( personDeepCopied.PersonJob.Sector == perSector );

            Assert.That( personDeepCopied.PersonAdress.Country == adrCountry );
            Assert.That( personDeepCopied.PersonAdress.City == adrCity );
            Assert.That( personDeepCopied.PersonAdress.District == adrDistrict );
            Assert.That( personDeepCopied.PersonAdress.Street == adrStreet );
            Assert.That( personDeepCopied.PersonAdress.Number == adrNumber );

            Assert.That( personDeepCopied.RelationShip.Relationship == personRelationship );
            #endregion
        }


        [Test]
        public void test_copy_changing_original_v2()
        {
            string personName = "test_name";
            string personId = "person_id";

            string adrCountry = "country_test";
            string adrCity = "city_test";
            string adrDistrict = "district_test";
            string adrStreet = "street_test";
            int adrNumber = 202;

            string perCompany = "company_test";
            string perJob = "job_test";
            string perSector = "sector_test";

            EnumRelationship personRelationship = EnumRelationship.Single;

            #region Original person
            Person personOriginal = new Person( personName, personId );

            PersonServiceDirector director = new PersonServiceDirector();
            director.Person = personOriginal;
            director.SetPersonAdress( country: adrCountry, city: adrCity, district: adrDistrict, street: adrStreet, number: adrNumber );
            director.SetPersonJob( company: perCompany, job: perJob, sector: perSector );
            director.SetPersonRelationship( relationship: personRelationship );
            #endregion

            #region Copy person
            Person personShallowCopied = personOriginal.ShallowCopy();
            Person personDeepCopied = personOriginal.DeepCopyV2();
            #endregion


            #region Change original person data
            string changedPersonName = "test_name_changed";
            string changedPersonId = "person_id_changed";

            string changedAdrCountry = "country_test_changed";
            string changedAdrCity = "city_test_changed";
            string changedAdrDistrict = "district_test_changed";
            string changedAdrStreet = "street_test_changed";
            int changedAdrNumber = 202;

            string changedPerCompany = "company_test_changed";
            string changedPerJob = "job_test_changed";
            string changedPerSector = "sector_test_changed";

            EnumRelationship changedPersonRelationship = EnumRelationship.Married;

            personOriginal.Name = changedPersonName;
            personOriginal.PersonID = changedPersonId;

            director.SetPersonAdress( country: changedAdrCountry, city: changedAdrCity, district: changedAdrDistrict, street: changedAdrStreet, number: changedAdrNumber );
            director.SetPersonJob( company: changedPerCompany, job: changedPerJob, sector: changedPerSector );
            director.SetPersonRelationship( relationship: changedPersonRelationship );
            #endregion

            #region Original person
            Assert.That( personOriginal.Name == changedPersonName );
            Assert.That( personOriginal.PersonID == changedPersonId );

            Assert.That( personOriginal.PersonJob.Company == changedPerCompany );
            Assert.That( personOriginal.PersonJob.Job == changedPerJob );
            Assert.That( personOriginal.PersonJob.Sector == changedPerSector );

            Assert.That( personOriginal.PersonAdress.Country == changedAdrCountry );
            Assert.That( personOriginal.PersonAdress.City == changedAdrCity );
            Assert.That( personOriginal.PersonAdress.District == changedAdrDistrict );
            Assert.That( personOriginal.PersonAdress.Street == changedAdrStreet );
            Assert.That( personOriginal.PersonAdress.Number == changedAdrNumber );

            Assert.That( personOriginal.RelationShip.Relationship == changedPersonRelationship );
            #endregion

            #region Shallow copied person
            Assert.That( personShallowCopied.Name == personName );
            Assert.That( personShallowCopied.PersonID == personId );

            Assert.That( personShallowCopied.PersonJob.Company == perCompany );
            Assert.That( personShallowCopied.PersonJob.Job == perJob );
            Assert.That( personShallowCopied.PersonJob.Sector == perSector );

            Assert.That( personShallowCopied.PersonAdress.Country == adrCountry );
            Assert.That( personShallowCopied.PersonAdress.City == adrCity );
            Assert.That( personShallowCopied.PersonAdress.District == adrDistrict );
            Assert.That( personShallowCopied.PersonAdress.Street == adrStreet );
            Assert.That( personShallowCopied.PersonAdress.Number == adrNumber );

            Assert.That( personShallowCopied.RelationShip.Relationship == personRelationship );
            #endregion

            #region Deep copied person
            Assert.That( personDeepCopied.Name == personName );
            Assert.That( personDeepCopied.PersonID == personId );

            Assert.That( personDeepCopied.PersonJob.Company == perCompany );
            Assert.That( personDeepCopied.PersonJob.Job == perJob );
            Assert.That( personDeepCopied.PersonJob.Sector == perSector );

            Assert.That( personDeepCopied.PersonAdress.Country == adrCountry );
            Assert.That( personDeepCopied.PersonAdress.City == adrCity );
            Assert.That( personDeepCopied.PersonAdress.District == adrDistrict );
            Assert.That( personDeepCopied.PersonAdress.Street == adrStreet );
            Assert.That( personDeepCopied.PersonAdress.Number == adrNumber );

            Assert.That( personDeepCopied.RelationShip.Relationship == personRelationship );
            #endregion
        }
    }
}
