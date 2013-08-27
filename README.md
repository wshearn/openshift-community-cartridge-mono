Getting Started with OpenShift and Mono
=========
---

####You will need:
  - [MonoDevelop 4][1]
  - [GIT][2]
  - [OpenShift account][3]

####Geting Started:
Sign into your OpenShift account and click the Create Application tab.
You then want to scroll to the VERY bottom and look for the text box that says: "URL to a cartridge defination"
Paste https://raw.github.com/wshearn/openshift-community-cartridge-mono/master/metadata/manifest.yml into the text box and click "Next"
Give a name to your application, we will be using "mono" as the name through out rest of this.
Once you have chosen a name click "Create Application" at the bottom.

After it has finished he creation process go ahead and start up MonoDevelop.

Insite MonoDevelop click on the menu item labeled "Version Control" then click on "Checkout"
Under the "Type" drop down box choose "Git".

Paste your git url you got at the end of the application creation wizard into the Url:// text box. Mine looks like
"ssh://51bcb3945973cac17a000040@mono-whearn.rhcloud.com/~/git/mono.git"
Chose a directory that does not exist for the "Target directory" I will use "/home/whearn/Projects/mono". Click on "OK". If you have git properly set up and your ssh key added to your OpenShift account you should see "Solution checked out".

Once that has finished click on "File" then "Open". Navigate to where you checked out your code(mine is /home/whearn/Projects/mono) and open OpenShift.csproj(Feel free to rename this.)

This project was created with Visual Studio 2012 so we need to fix a few things. In your solution explorer expand "OpenShift" and "References". Right click References and click on "Edit References". Click on the tab called ".Net Assembly". Navigate to where you checked out your project and go into the "bin" directory" Hold control and click on the following dll files:
 - Antlr3.Runtime.dll
 - EntityFramework.dll
 - Microsoft.Data.Edm.dll
 - Microsoft.Data.OData.dll
 - Microsoft.Web.Infrastructure.dll
 - Microsoft.Web.Mvc.FixedDisplayModes.dll
 - Newtonsoft.Json.dll
 - System.Data.Entity.dll
 - System.Net.Http.dll
 - System.Net.Http.Formatting.dll
 - System.Net.Http.WebRequest.dll
 - System.Spatial.dll
 - System.Web.Helpers.dll
 - System.Web.Http.dll
 - System.Web.Http.OData.dll
 - System.Web.Http.WebHost.dll
 - System.Web.Mvc.dll
 - System.Web.Optimization.dll
 - System.Web.Razor.dll
 - System.Web.WebPages.Deployment.dll
 - System.Web.WebPages.dll
 - System.Web.WebPages.Razor.dll
 - WebGrease.dll
 - WebMatrix.Data.dll
 - WebMatrix.WebData.dll

Click on the button labeled "Add". Then click on OK.
Now you want to hold control and click on all the references that are red in side the solution explorer. Then press delete or right click and in the context menu click on "Delete".

You should now be able to press F8 (Windows/Linux) or CMD+B (OS X) to build the solution. Congratulations you are now ready to create your website! 

To push your changes up to OpenShift click on "Version Control" and click on "Commit Solution"
Write a short commit message and press "Commit". Click back on "Version Control" and press "Push Changes" then click the button labeled "Push Changes". After a bit your new site will be up.

[1]: http://www.monodevelop.com/
[2]: http://git-scm.com/
[3]: http://www.openshift.com/
