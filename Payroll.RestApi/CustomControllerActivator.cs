using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace Payroll.RestApi
{
    public class CustomControllerActivator : IControllerActivator
    {
        public object Create(ControllerContext context)
        {
            var controllerType = context.ActionDescriptor.ControllerTypeInfo.AsType();
            var controller = Activator.CreateInstance(controllerType);
            return controller;
        }

        public void Release(ControllerContext context, object controller)
        {
            // nothing to do here
        }
    }
}