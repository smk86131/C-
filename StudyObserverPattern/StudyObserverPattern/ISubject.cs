using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyObserverPattern
{
    public interface ISubject
    {
        void register(IObserver o);
        void remove(IObserver o);
        void notify(); //관찰자들(옵저버들)에게 일괄통지할 함수
    }
}
