using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            var builder = WebApplication.CreateBuilder();
            var app = builder.Build();


            app.MapPost("/main", async([FromForm] int firstNumber, [FromForm] int secondNumber)=>
            {
                RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
                int RandomValue = randomNumberGenerator.GenerateRandomNumber(firstNumber, secondNumber);

                return Results.Text(Convert.ToString(RandomValue));




            });
            app.MapGet("/index", async ( context) =>
            {
                context.Response.ContentType = "text/html;charset=utf-8";

                await context.Response.SendFileAsync("html/index.html");
            });


            app.Run();
        }


    }
}
