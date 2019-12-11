using System;
using System.Collections.Generic;
using ConwaysGameOfLife;
using NUnit.Framework;

    //At each step in time, the following transitions occur:

    //Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
    //Any live cell with more than three live neighbours dies, as if by overcrowding.
    //Any live cell with two or three live neighbours lives on to the next generation.
    //Any dead cell with exactly three live neighbours becomes a live cell.

namespace ConwaysGameOfLifeTest
{
    public class GameOfLifeTests
    {
        [Test]
        public void FirstRule()
        {
            // [d, d, d]
            // [d, a, d]
            // [d, d, d]
            //   

            var world = new World(new List<List<Cell>>
            {
                new List<Cell> {new Cell(false), new Cell(false), new Cell(false)},
                new List<Cell>  {new Cell(false), new Cell(true), new Cell(false)},
                new List<Cell> {new Cell(false), new Cell(false), new Cell(false)}

            });

            var nextWorld = world.Step();

            var expectedState = new List<List<Cell>>
            {
                new List<Cell> {new Cell(false), new Cell(false), new Cell(false)},
                new List<Cell> {new Cell(false), new Cell(false), new Cell(false)},
                new List<Cell> {new Cell(false), new Cell(false), new Cell(false)}
            };

            // nextWorld.State to Equal expectedState
            Assert.AreEqual(expectedState, nextWorld.State);
        }
    }
}
