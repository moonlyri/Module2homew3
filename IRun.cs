using System;
namespace Module2HM3
{
    public interface IRun
    {
        public class RunnerService
        {
            private IRun[] _runners;
            public RunnerService(IRun[] runners)
            {
                _runners = runners;
            }
        }
    }
    public interface ISleep
    {
        
    }
    public interface IEat
    {
        public class EaterService
        {
            private IEat[] _eaters;
            public EaterService(IEat[] eaters)
            {
                _eaters = eaters;
            }
        }
    }
    public interface IPurr
    {
        public class PurrService
        {
            private IPurr[] _purr;
            public PurrService(IPurr[] purrs)
            {
                _purr = purrs;
            }
        }
    }
}

