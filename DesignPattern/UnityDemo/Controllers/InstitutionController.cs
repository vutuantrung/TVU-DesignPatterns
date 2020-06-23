using ServicesCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnityDemo.Controllers
{
    public class InstitutionController : Controller
    {
        private IInstitutionService _institutionService;

        public InstitutionController( IInstitutionService insitutionService )
        {
            _institutionService = insitutionService;
        }

        // GET: Institution
        public ActionResult Index()
        {
            return View( _institutionService.GetInstitutionByID( 1 ) );
        }
    }
}