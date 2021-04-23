using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TestUwp.Models;

namespace TestUwp.Services
{
    public static class SampleDataService
    {
        private static IEnumerable<Assignature> AllAssignature()
        {
            var professor = AllProfessors();
            return professor.SelectMany(c => c.Assignatures);
        }

        private static IEnumerable<Professor> AllProfessors()
        {
            return new List<Professor>()
            {
                new Professor()
                {
                    ProfessorID = "Prof01",
                    ProfessorName = "Javier",
                    ProfessorLastName = "Vargas",
                    City = "Chia",
                    Assignatures = new List<Assignature>()
                    {
                        new Assignature()
                        {
                            AssignatureID = 100,
                            AssignatureName = "Chemistry",
                            Status = "Active",
                            Students = new List<Students>()
                            {
                                new Students()
                                {
                                    StudentsID = 2238,
                                    StudentsName = "Maira Vargas",
                                    StudentsCity = "Bogota",
                                },
                                new Students()
                                {
                                    StudentsID = 223,
                                    StudentsName = "Sofia Rueda",
                                    StudentsCity = "Bogota",
                                },
                                new Students()
                                {
                                    StudentsID = 2832,
                                    StudentsName = "Jhon Vargas",
                                    StudentsCity = "Bogota",
                                },
                            }
                        },
                        new Assignature()
                        {
                            AssignatureID = 10643,
                            AssignatureName = "Speedy Express",
                            Status = "Shipped",
                            Students = new List<Students>()
                            {
                                new Students()
                                {
                                    StudentsID = 73,
                                    StudentsName = "Edna Romero",
                                    StudentsCity = "La Calera",
                                },
                                new Students()
                                {
                                    StudentsID = 88,
                                    StudentsName = "Alex Romero",
                                    StudentsCity = "Madrid",
                                },
                                new Students()
                                {
                                    StudentsID = 09,
                                    StudentsName = "Javier Garcia",
                                    StudentsCity = "Facatativa",
                                },
                            }
                        },
                        new Assignature()
                        {
                            AssignatureID = 10643,
                            AssignatureName = "Speedy Express",
                            Status = "Shipped",
                            Students = new List<Students>()
                            {
                                new Students()
                                {
                                    StudentsID = 32,
                                    StudentsName = "Jairo Vargas",
                                    StudentsCity = "New York",
                                },
                                new Students()
                                {
                                    StudentsID = 89,
                                    StudentsName = "Lilian Arce",
                                    StudentsCity = "Barranquilla",
                                },
                                new Students()
                                {
                                    StudentsID = 67,
                                    StudentsName = "Julio Jaramillo",
                                    StudentsCity = "Caracas",
                                },
                            }
                        },
                    }
                },
                new Professor()
                {
                    ProfessorID = "Prof02",
                    ProfessorName = "Fausto",
                    ProfessorLastName = "Fitzgerald",
                    City = "Berlin",
                    Assignatures = new List<Assignature>()
                    {
                        new Assignature()
                        {
                            AssignatureID = 2,
                            AssignatureName = "Phisycs",
                            Status = "Active",
                            Students = new List<Students>()
                            {
                                new Students()
                                {
                                    StudentsID = 28,
                                    StudentsName = "Javier Camargo",
                                    StudentsCity = "Bogota",
                                },
                                new Students()
                                {
                                    StudentsID = 29,
                                    StudentsName = "Andres Lopez",
                                    StudentsCity = "Bogota",
                                },
                                new Students()
                                {
                                    StudentsID = 18,
                                    StudentsName = "Maria Siberia",
                                    StudentsCity = "Bogota",
                                },
                            }
                        },
                        new Assignature()
                        {
                            AssignatureID = 10,
                            AssignatureName = "Algebra",
                            Status = "Active",
                            Students = new List<Students>()

                        },
                        new Assignature()
                        {
                            AssignatureID = 104,
                            AssignatureName = "Logical",
                            Status = "Active",
                            Students = new List<Students>()
                            {
                                new Students()
                                {
                                    StudentsID = 32,
                                    StudentsName = "Jairo Vargas",
                                    StudentsCity = "New York",
                                },
                                new Students()
                                {
                                    StudentsID = 89,
                                    StudentsName = "Lilian Arce",
                                    StudentsCity = "Barranquilla",
                                },
                                new Students()
                                {
                                    StudentsID = 67,
                                    StudentsName = "Julio Jaramillo",
                                    StudentsCity = "Caracas",
                                },
                            }
                        },
                    }
                },
                new Professor()
                {
                    ProfessorID = "03",
                    ProfessorName = "Albert",
                    ProfessorLastName = "Kamus",
                    City = "London",
                    Assignatures = new List<Assignature>()
                    {
                        new Assignature()
                        {
                            AssignatureID = 4,
                            AssignatureName = "English",
                            Status = "Active",
                            Students = new List<Students>()
                            {
                                new Students()
                                {
                                    StudentsID = 32,
                                    StudentsName = "Jairo Vargas",
                                    StudentsCity = "New York",
                                },
                                new Students()
                                {
                                    StudentsID = 89,
                                    StudentsName = "Lilian Arce",
                                    StudentsCity = "Barranquilla",
                                },
                                new Students()
                                {
                                    StudentsID = 67,
                                    StudentsName = "Julio Jaramillo",
                                    StudentsCity = "Caracas",
                                },
                            }
                        },
                        new Assignature()
                        {
                            AssignatureID = 04,
                            AssignatureName = "French",
                            Status = "Active",
                            Students = new List<Students>()
                            {
                                new Students()
                                {
                                    StudentsID = 77,
                                    StudentsName = "Joshua Abraham",
                                    StudentsCity = "Lima",
                                },
                                new Students()
                                {
                                    StudentsID = 13,
                                    StudentsName = "Hammilton Beckan",
                                    StudentsCity = "Antofagasta",
                                },
                                new Students()
                                {
                                    StudentsID = 42,
                                    StudentsName = "Joshep Lewit",
                                    StudentsCity = "Soacha",
                                },
                            }
                        },
                        new Assignature()
                        {
                            AssignatureID = 09,
                            AssignatureName = "Biology",
                            Status = "Active",
                            Students = new List<Students>()
                            {
                                new Students()
                                {
                                    StudentsID = 73,
                                    StudentsName = "Edna Romero",
                                    StudentsCity = "La Calera",
                                },
                                new Students()
                                {
                                    StudentsID = 88,
                                    StudentsName = "Alex Romero",
                                    StudentsCity = "Madrid",
                                },
                                new Students()
                                {
                                    StudentsID = 09,
                                    StudentsName = "Javier Garcia",
                                    StudentsCity = "Facatativa",
                                },
                            }
                        },
                    }
                },
            };
        }


        public static async Task<IEnumerable<Professor>> GetTreeViewDataAsync()
        {
            await Task.CompletedTask;
            return AllProfessors();
        }
    }
}