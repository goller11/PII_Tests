using System;
using Xunit;

namespace Testing {

    public class Tests {

        [Fact]
        public void TestLetra () {
            Library letra = new Library ("Boom", "a");
            const bool expected = false;
            Assert.Equal (expected, Library.ValidateID (letra.CI));
        }

        [Fact]
        public void TestValida () {
            Library valida = new Library ("Cool", "50968735");
            const bool expected = true;
            Assert.Equal (expected, Library.ValidateID (valida.CI));
        }

        [Fact]
        public void TestInvalida () {
            Library invalida = new Library ("Uncool", "12345678");
            const bool expected = false;
            Assert.Equal (expected, Library.ValidateID (invalida.CI));
        }

        [Fact]
        public void TestSimbolos () {
            Library con_simbolos = new Library ("Da best!", "5.096.873-5");
            const bool expected = false;
            Assert.Equal (expected, Library.ValidateID (con_simbolos.CI));
        }
    }
}