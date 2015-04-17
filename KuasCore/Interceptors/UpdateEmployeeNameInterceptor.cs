using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using AopAlliance.Intercept;
using KuasCore.Models;

namespace KuasCore.Interceptors
{
    class UpdateEmployeeNameInterceptor : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine("DebogLogInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("DebogLogInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            object result = invocation.Proceed();
            Employee employee = (Employee)result;
            employee.Name= employee.Name+ "老師~~~~~~";
            Console.WriteLine("回傳的資料已取得 [{0}]", result);
            
            Debug.Print("回傳的資料已取得 [{0}]", result);

            return result;
        }
    }
}
