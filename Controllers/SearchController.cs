﻿using Microsoft.AspNetCore.Mvc;
using SearchMovie.API;

namespace SearchMovie.Controllers
{
    public class SearchController : Controller
    {
        MovieAPI _movieAPI = new MovieAPI("931237d");
        
        public async Task<IActionResult> Index(string search)
        {
            if (search == null)
            {
                search = "Spider";
            }
            var searchResponse = await _movieAPI.GetSearchResponse(search);
            return View(searchResponse.Search);
        }

        public async Task<IActionResult> Movie(string id)
        {
            var movie = await _movieAPI.GetMovie(id);
            return View(movie);
        }
    }
}
