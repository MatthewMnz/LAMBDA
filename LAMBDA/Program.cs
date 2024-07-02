namespace LAMBDA
{
    class Program
    { 
        static void Main (String[] args)
        {
            List<Student> estudiantes = new List<Student>
            {
                new Student("Ismael Asensio", 20, 90),
                new Student("Juan Espinoza", 19, 70),
                new Student("Nestor Soto", 20, 80),
                new Student("Keneth Palacios", 19, 80),
                new Student("Alvaro Garay", 20, 60)
            };

            var estudianteNotaAlta = estudiantes.OrderByDescending(e => e.Nota).FirstOrDefault();
            Console.WriteLine($"El estudiante con la nota mas alta es: {estudianteNotaAlta.Nombre} - Nota: {estudianteNotaAlta.Nota}");

            var estudiantesPorOrden = estudiantes.OrderBy(e => e.Nombre).ToList();
            Console.WriteLine("Lista de estudiantes ordenados por su nombre:");
            foreach (var student in estudiantesPorOrden)
            {
                Console.WriteLine($"{student.Nombre} - Edad: {student.Edad} - Nota: {student.Nota}");
            }

            var promedioNotas = estudiantes.Average(e => e.Nota);
            Console.WriteLine($"Promedio de notas de estudiantes: {promedioNotas}");

            Console.ReadLine();
        }
    }


}
