﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppVentaCursosContext()){
                //AsNoTracking: método evita almacenar data en caché, pido la data e inmediatamente la trae no la guarda en cache
                var cursos = db.Curso.Include(c => c.InstructorLink).ThenInclude (ci => ci.Instructor);
                foreach(var curso in cursos){
                    Console.WriteLine(curso.Titulo);
                    foreach(var insLink in curso.InstructorLink){
                        Console.WriteLine("*******" + insLink.Instructor.Nombre);
                        
                    }
                    
                }
                    }
                }
            }
        }
