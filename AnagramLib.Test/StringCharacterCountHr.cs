using System;
using System.Linq;
using Xunit;

namespace AnagramLib.Test
{
    public class StringCharacterCountHr
    {
        [Fact]
        public void Instance()
        {
            var instance = new AnagramLib.StringCharaterCount();

            Assert.NotNull(instance.Data);
        }

        [Fact]
        public void InstanceSimple1()
        {
            var data = "adz";
            var instance = new AnagramLib.StringCharaterCount("adz");

            Assert.NotNull(instance.Data);
            Assert.Equal(instance.Data['a'], 1);
            Assert.Equal(instance.Data['b'], 0);
            Assert.Equal(instance.Data['c'], 0);
            Assert.Equal(instance.Data['č'], 0);
            Assert.Equal(instance.Data['ć'], 0);
            Assert.Equal(instance.Data['d'], 1);
            Assert.Equal(instance.Data['đ'], 0);
            Assert.Equal(instance.Data['e'], 0);
            Assert.Equal(instance.Data['f'], 0);
            Assert.Equal(instance.Data['g'], 0);
            Assert.Equal(instance.Data['h'], 0);
            Assert.Equal(instance.Data['i'], 0);
            Assert.Equal(instance.Data['j'], 0);
            Assert.Equal(instance.Data['k'], 0);
            Assert.Equal(instance.Data['l'], 0);
            Assert.Equal(instance.Data['m'], 0);
            Assert.Equal(instance.Data['n'], 0);
            Assert.Equal(instance.Data['o'], 0);
            Assert.Equal(instance.Data['p'], 0);
            Assert.Equal(instance.Data['r'], 0);
            Assert.Equal(instance.Data['s'], 0);
            Assert.Equal(instance.Data['š'], 0);
            Assert.Equal(instance.Data['t'], 0);
            Assert.Equal(instance.Data['u'], 0);
            Assert.Equal(instance.Data['v'], 0);
            Assert.Equal(instance.Data['z'], 1);
            Assert.Equal(instance.Data['ž'], 0);
        }

        [Fact]
        public void InstanceSimple2()
        {
            var instance = new AnagramLib.StringCharaterCount("ažđžć");

            Assert.NotNull(instance.Data);
            Assert.Equal(instance.Data['a'], 1);
            Assert.Equal(instance.Data['b'], 0);
            Assert.Equal(instance.Data['c'], 0);
            Assert.Equal(instance.Data['č'], 0);
            Assert.Equal(instance.Data['ć'], 1);
            Assert.Equal(instance.Data['d'], 0);
            Assert.Equal(instance.Data['đ'], 1);
            Assert.Equal(instance.Data['e'], 0);
            Assert.Equal(instance.Data['f'], 0);
            Assert.Equal(instance.Data['g'], 0);
            Assert.Equal(instance.Data['h'], 0);
            Assert.Equal(instance.Data['i'], 0);
            Assert.Equal(instance.Data['j'], 0);
            Assert.Equal(instance.Data['k'], 0);
            Assert.Equal(instance.Data['l'], 0);
            Assert.Equal(instance.Data['m'], 0);
            Assert.Equal(instance.Data['n'], 0);
            Assert.Equal(instance.Data['o'], 0);
            Assert.Equal(instance.Data['p'], 0);
            Assert.Equal(instance.Data['r'], 0);
            Assert.Equal(instance.Data['s'], 0);
            Assert.Equal(instance.Data['š'], 0);
            Assert.Equal(instance.Data['t'], 0);
            Assert.Equal(instance.Data['u'], 0);
            Assert.Equal(instance.Data['v'], 0);
            Assert.Equal(instance.Data['z'], 0);
            Assert.Equal(instance.Data['ž'], 2);
        }

        [Fact]
        public void InstanceLowerUpperLetters1()
        {
            var instance = new AnagramLib.StringCharaterCount("cbBBbCc");

            Assert.NotNull(instance.Data);
            Assert.Equal(instance.Data['a'], 0);
            Assert.Equal(instance.Data['b'], 4);
            Assert.Equal(instance.Data['c'], 3);
            Assert.Equal(instance.Data['č'], 0);
            Assert.Equal(instance.Data['ć'], 0);
            Assert.Equal(instance.Data['d'], 0);
            Assert.Equal(instance.Data['đ'], 0);
            Assert.Equal(instance.Data['e'], 0);
            Assert.Equal(instance.Data['f'], 0);
            Assert.Equal(instance.Data['g'], 0);
            Assert.Equal(instance.Data['h'], 0);
            Assert.Equal(instance.Data['i'], 0);
            Assert.Equal(instance.Data['j'], 0);
            Assert.Equal(instance.Data['k'], 0);
            Assert.Equal(instance.Data['l'], 0);
            Assert.Equal(instance.Data['m'], 0);
            Assert.Equal(instance.Data['n'], 0);
            Assert.Equal(instance.Data['o'], 0);
            Assert.Equal(instance.Data['p'], 0);
            Assert.Equal(instance.Data['r'], 0);
            Assert.Equal(instance.Data['s'], 0);
            Assert.Equal(instance.Data['š'], 0);
            Assert.Equal(instance.Data['t'], 0);
            Assert.Equal(instance.Data['u'], 0);
            Assert.Equal(instance.Data['v'], 0);
            Assert.Equal(instance.Data['z'], 0);
            Assert.Equal(instance.Data['ž'], 0);
        }

        [Fact]
        public void InstanceWithSpace()
        {
            var instance = new AnagramLib.StringCharaterCount(" žđ ab  th");

            Assert.NotNull(instance.Data);
            Assert.Equal(instance.Data['a'], 1);
            Assert.Equal(instance.Data['b'], 1);
            Assert.Equal(instance.Data['c'], 0);
            Assert.Equal(instance.Data['č'], 0);
            Assert.Equal(instance.Data['ć'], 0);
            Assert.Equal(instance.Data['d'], 0);
            Assert.Equal(instance.Data['đ'], 1);
            Assert.Equal(instance.Data['e'], 0);
            Assert.Equal(instance.Data['f'], 0);
            Assert.Equal(instance.Data['g'], 0);
            Assert.Equal(instance.Data['h'], 1);
            Assert.Equal(instance.Data['i'], 0);
            Assert.Equal(instance.Data['j'], 0);
            Assert.Equal(instance.Data['k'], 0);
            Assert.Equal(instance.Data['l'], 0);
            Assert.Equal(instance.Data['m'], 0);
            Assert.Equal(instance.Data['n'], 0);
            Assert.Equal(instance.Data['o'], 0);
            Assert.Equal(instance.Data['p'], 0);
            Assert.Equal(instance.Data['r'], 0);
            Assert.Equal(instance.Data['s'], 0);
            Assert.Equal(instance.Data['š'], 0);
            Assert.Equal(instance.Data['t'], 1);
            Assert.Equal(instance.Data['u'], 0);
            Assert.Equal(instance.Data['v'], 0);
            Assert.Equal(instance.Data['z'], 0);
            Assert.Equal(instance.Data['ž'], 1);
        }
    }
}
