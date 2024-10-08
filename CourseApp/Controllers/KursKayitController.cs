﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CourseApp.Controllers
{
    public class KursKayitController : Controller
    {
        private readonly DataContext _context;

        public KursKayitController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var kursKayitlari = await _context
                                      .KursKayitlari
                                      .Include(x => x.Ogrenci)
                                      .Include(x => x.Kurs)
                                      .ToListAsync();
            return View(kursKayitlari);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Ogrenciler = new SelectList(await _context.Ogrenciler.ToListAsync(), "OgrenciID", "OgrenciAd");
            ViewBag.Kurslar = new SelectList(await _context.Kurslar.ToListAsync(), "KursID", "Baslik");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(KursKayit model)
        {
            model.KayitTarihi = DateTime.Now;
            _context.KursKayitlari.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kursKaydi = await _context.KursKayitlari.FindAsync(id);

            if (kursKaydi == null)
            {
                return NotFound();
            }

            return View(kursKaydi);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm] int id)
        {
            var kursKaydi = await _context.KursKayitlari.FindAsync(id);
            if (kursKaydi == null)
            {
                return NotFound();
            }
            _context.KursKayitlari.Remove(kursKaydi);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
