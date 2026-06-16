using System.Linq;
using System.Web.Mvc;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeDbContext db = new EmployeeDbContext();

        public ActionResult Index(string searchTerm)
        {
            var employees = db.Employees.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                employees = employees.Where(e =>
                    e.Name.Contains(searchTerm));
            }

            return View(employees.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = db.Employees.Find(id);

            if (employee == null)
            {
                return HttpNotFound();
            }

            return View(employee);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State =
                    System.Data.Entity.EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            var employee = db.Employees.Find(id);

            if (employee == null)
            {
                return HttpNotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var employee = db.Employees.Find(id);

            db.Employees.Remove(employee);

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}