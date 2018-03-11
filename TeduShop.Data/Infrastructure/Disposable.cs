using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    class Disposable : IDisposable
    {
        private bool isDisposable;
        ~Disposable()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if(!isDisposable && disposing)
            {
                DisposeCore();
            }
            isDisposable = true;
        }

        public  void DisposeCore()
        {
            throw new NotImplementedException();
        }
    }
}
