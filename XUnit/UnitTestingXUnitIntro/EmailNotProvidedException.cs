using System;

namespace UnitTestingXUnitIntro
{
    public class EmailNotProvidedException : Exception
    {
        public override string Message => "Email can't be empty";
    }
}
