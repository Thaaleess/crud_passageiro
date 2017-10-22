using crud_passageiro.Models;
using Microsoft.AspNetCore.Mvc;

namespace crud_passageiro.Controllers
{
    public class PassageiroController : Controller
    {
        private readonly IPassageiroRepository _repository;

        public PassageiroController(IPassageiroRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index(){
            var passageiros = _repository.GetAll();
            return View(passageiros);
        }

        [HttpGet]
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Passageiro passageiro){
            _repository.Create(passageiro);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id){
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Passageiro passageiro){
            _repository.Update(passageiro);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id){
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}