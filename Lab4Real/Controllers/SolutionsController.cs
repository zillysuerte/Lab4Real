using Microsoft.AspNetCore.Mvc;

namespace Lab4Real.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SolutionsController : ControllerBase
    {
        private static readonly SolutionsData solutions = new SolutionsData();

        private static EquationSolver solver = new EquationSolver();


        [HttpGet("/Solutions/GetSolutionsData")]
        public EquationSolver GetSolutionsData()
        {
            return solver;
        }
        [HttpGet("/Solutions/Create")]
        public IActionResult Create([FromBody] EquationsData equationsData)
        {

            EquationMember cx = new EquationMember(equationsData.C, 0);
            EquationMember bx = new EquationMember(equationsData.B, 1);
            EquationMember ax = new EquationMember(equationsData.A, 2);

            var parts = new EquationMember[] { cx, bx, ax };

            Equation equation = new Equation(parts);
            Solution solution = equation.Result;
            //solver.Add(solution);

            solver.Add(solution);
            return Ok();
        }

        [HttpGet("/Solutions/HasRoots")]
        public bool HasRoots(int id)
        {
            return solver.GetEquationAt(id - 1).HasRoots;
        }


        [HttpGet("/Solutions/GetEquationAt")]
        public SolutionsData GetEquationAt(int id)
        {
            return solver.GetEquationAt(id - 1).toSolutionsData();
        }



    }
}
