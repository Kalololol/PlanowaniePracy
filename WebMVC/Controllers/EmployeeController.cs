using Application.Services.Employees.Commands.CreateEmployee;
using Application.Services.Employees.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly  IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: EmployeeController
        public ActionResult GetAll(int wardId)
        {

            var result =  _mediator.Send(new GetEmployeesListQuery(wardId));

            return View(result);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var result = _mediator.Send(new GetEmployeeByIdQuery(id));
            return View(result); 
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {            
            return View(new EmployeeModel());
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeModel employee)
        {
            var result = _mediator.Send(new CreateEmployeeCommand());
            return RedirectToAction(nameof(Index));
            

        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeModel employee)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
