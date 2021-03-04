using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            try
            {
                foreach (var logic in logics)
                {
                    if (!logic.Success)
                    {
                        return logic;
                    }
                }

                return null;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
