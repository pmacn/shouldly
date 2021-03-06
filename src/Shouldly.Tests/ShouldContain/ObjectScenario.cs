﻿using Shouldly.Tests.TestHelpers;
using System;

namespace Shouldly.Tests.ShouldContain
{
    public class ObjectScenario : ShouldlyShouldTestScenario
    {
        protected override void ShouldThrowAWobbly()
        {
            var a = new Object();
            var b = new Object();
            var c = new Object();
            var d = new Object();
            new[] { a, b, c }.ShouldContain(d, "Some additional context");
        }

        protected override string ChuckedAWobblyErrorMessage
        {
            get { return @"
    new[] { a, b, c }
        should contain
    System.Object
        but does not
    Additional Info:
    Some additional context"; }
        }

        protected override void ShouldPass()
        {
            var a = new Object();
            var b = new Object();
            var c = new Object();
            new[] { a, b, c }.ShouldContain(b);
        }
    }
}