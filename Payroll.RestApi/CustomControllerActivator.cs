using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Payroll.Application;
using Payroll.RestApi.Controllers;

namespace Payroll.RestApi
{
    public class CustomControllerActivator : IControllerActivator
    {
        public object Create(ControllerContext context)
        {
            var controllerType = context.ActionDescriptor.ControllerTypeInfo.AsType();

            if (controllerType == typeof(EmployeeController))
            {
                return new EmployeeController(new InMemoryEmployeeRepository());
            }
            else
            {
                return Activator.CreateInstance(controllerType);
            }
        }

        public void Release(ControllerContext context, object controller)
        {
            // nothing to do here
        }
    }
}