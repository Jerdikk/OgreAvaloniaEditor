using Avalonia;
using Avalonia.Controls;
using Avalonia.Threading;
using OgreAvaloniaEditor.Views;
using System;
using org.ogre;
using System.Threading;
using System.Xml.Linq;
using System.Runtime.Intrinsics.Arm;
using System.IO;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace OgreAvaloniaEditor.ViewModels
{
  public class MainWindowViewModel : ViewModelBase
    {
        public IntPtr WindowHandle { get; set; }
        org.ogre.ApplicationContext ctx;
        string mAppName;
        bool isRunning;


        private MainWindow _mainWindow;
        public MainWindow mainWindow
        {
            get
            { return _mainWindow; }
            set
            {
                _mainWindow = value;
            }
        }

        private DateTime _prevTime;
        private DateTime _now;
        private string mNextRenderer;
        private ShaderGenerator mShaderGenerator;

        public MainWindowViewModel()
        {
            isRunning = false;
            WindowHandle = IntPtr.Zero;
            StartClock();

        }

        private void StartClock()
        {
            new DispatcherTimer(TimeSpan.FromMilliseconds(16), DispatcherPriority.Normal, TimerTick).Start();
        }

        void TimerTick(object sender, EventArgs e)
        {
            _now = DateTime.Now;

            if (WindowHandle == IntPtr.Zero)
            {
                WindowHandle = mainWindow.ogreControl.m_Handle;
                mAppName = "OgreEditor";

                ctx = new org.ogre.ApplicationContext("OgreEditor");
                ctx.initApp();

                ctx.destroyWindow("OgreEditor");

                org.ogre.NameValueMap misc = new NameValueMap();
                misc["externalWindowHandle"] = WindowHandle.ToString();

                RenderWindow window = ctx.getRoot().createRenderWindow("Main RenderWindow", 800, 600, false, misc);

                // get a pointer to the already created mRoot
                Root mRoot = ctx.getRoot();
                SceneManager scnMgr = mRoot.createSceneManager();

                // register our scene with the RTSS
                ShaderGenerator shadergen = ShaderGenerator.getSingleton();
                shadergen.addSceneManager(scnMgr);

                // without light we would just get a black screen    
                Light light = scnMgr.createLight("MainLight");
                SceneNode lightNode = scnMgr.getRootSceneNode().createChildSceneNode();
                lightNode.setPosition(0, 10, 15);
                lightNode.attachObject(light);

                // also need to tell where we are
                SceneNode camNode = scnMgr.getRootSceneNode().createChildSceneNode();
                camNode.setPosition(0, 0, 15);
                camNode.lookAt(new Vector3(0, 0, -1), Node.TransformSpace.TS_PARENT);

                // create the camera
                Camera cam = scnMgr.createCamera("myCam");
                cam.setNearClipDistance(5); // specific to this sample
                cam.setAutoAspectRatio(true);
                camNode.attachObject(cam);

                Viewport viewport = window.addViewport(cam);
                viewport.setBackgroundColour(ColourValue.Black);

                cam.setAspectRatio((float)viewport.getActualWidth() / (float)viewport.getActualHeight());
                               

                // finally something to render
                Entity ent = scnMgr.createEntity("Sinbad.mesh");
                SceneNode node = scnMgr.getRootSceneNode().createChildSceneNode();
                node.attachObject(ent);


                isRunning = true;
                //  Thread thread = new Thread(Go);
                //  thread.Start();


            }
            else
            {
                TimeSpan ts = _now - _prevTime;
                _prevTime = _now;
                if (isRunning)
                    ctx.getRoot().renderOneFrame();
            }

        }

        private void SplitFilename(string qualifiedName, out string outBasename, out string outPath)
        {

            String path = qualifiedName;
            // Replace \ with / first
            path = path.Replace('\\', '/');
            // split based on final /
            int i = path.LastIndexOf('/');

            if (i == -1)
            {
                outPath = "";
                outBasename = qualifiedName;
            }
            else
            {
                outBasename = path.Substring(i + 1, path.Length - i - 1);
                outPath = path.Substring(0, i + 1);
            }

        }


    }
}