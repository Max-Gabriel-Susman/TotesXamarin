using System;

using UIKit;

namespace totesXamarin.iOS.ViewControllers
{
    public partial class TransactionDetailViewController : UIViewController
    {
        public TransactionDetailViewController() : base("TransactionDetailViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

