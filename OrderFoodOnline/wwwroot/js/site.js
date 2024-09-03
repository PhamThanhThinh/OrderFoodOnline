// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let apiURL = "https://forkify-api.herokuapp.com/api/v2/recipes";
let apikey = "24f1b31f-b2a7-4161-85ef-9736fbf6b268";

async function GetRecipes(recipeName, id, isAllShow) {
  let resp = await fetch(`${apiURL}?search=${recipeName}&key=${apikey}`);
  let result = await resp.json();
  //console.log(result);
  /*xử lý ngoại lệ*/
  let Recipes = isAllShow ? result.data.recipes : result.data.recipes.slice(0, 12);
  showRecipes(Recipes, id);
}

// `${apiURL}?search=${recipeName}` là một dạng biểu thức trong js
/*
${ } nhúng biến vào trong cú pháp của biểu thức
*/

//Ví dụ URL: https://forkify-api.herokuapp.com/api/v2/recipes?search=pizza&key=<insert your key>

function showRecipes(recipes, id) {
  $.ajax({
    contentType: "application/json; charset=utf-8",
    dataType: 'html',
    type: 'POST',
    url: '/Recipe/GetRecipeCard',
    data: JSON.stringify(recipes),
    success: function (htmlResult) {
      $('#' + id).html(htmlResult);
    }
  });
}