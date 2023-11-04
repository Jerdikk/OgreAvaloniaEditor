using Avalonia;
using Avalonia.Controls;
using Avalonia.Threading;
using OgreAvaloniaEditor.Views;
using System;
using org.ogre;
using System.Threading;

namespace OgreAvaloniaEditor.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public IntPtr WindowHandle { get; set; }
        org.ogre.ApplicationContext ctx;
        bool isRunning;


        private MainWindow _mainWindow;
        public MainWindow mainWindow
        {  get 
            { return _mainWindow; } 
            set
            {
                _mainWindow = value;
            }
        }

        private DateTime _prevTime ;
        private DateTime _now;
        

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
            if (WindowHandle == IntPtr.Zero)
            {
                WindowHandle = mainWindow.ogreControl.m_Handle;

                ctx = new org.ogre.ApplicationContext("OgreTutorialApp");
                ctx.initApp();

                ctx.destroyWindow("OgreTutorialApp");

                org.ogre.NameValueMap misc = new NameValueMap();
                misc["externalWindowHandle"] = WindowHandle.ToString();

                RenderWindow window = ctx.getRoot().createRenderWindow("Main RenderWindow", 800, 600, false, misc);

                // get a pointer to the already created root
                Root root = ctx.getRoot();
                SceneManager scnMgr = root.createSceneManager();

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

                // and tell it to render into the main window
                //ctx.getRenderWindow().addViewport(cam);

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
                _prevTime = _now;
                _now = DateTime.Now;

                TimeSpan ts = _now - _prevTime;

             //   if (ts.Milliseconds > 10)
                {
                    ctx.getRoot().renderOneFrame();
                }
            }

        }
      
    }
}