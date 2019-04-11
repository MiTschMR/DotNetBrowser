using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace DotNetBrowser
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public class WPFBitmapConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
        System.Globalization.CultureInfo culture)
        {
            MemoryStream ms = new MemoryStream();
            ((System.Drawing.Bitmap)value).Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();

            return image;
        }
        public object ConvertBack(object value, Type targetType, object parameter,
        System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public partial class MainWindow : Window
    {
        private const string classesNamesResxFile = "APIs/Classes/Classes";
        private const string classesDescriptionsResxFile = @".\APIs\Classes\Descriptions.resx";
        public MainWindow()
        {
            #region GuiInitialization

            InitializeComponent();

            #endregion GuiInitialization

            #region Variabledefinitions

            List<Namespace> listNamespaces = new List<Namespace>();

            #region Namespaces

            string namespaces_Accessibility = DotNetBrowser.APIs.Namespaces.Namespaces.Accessibility_Namespaces;
            string[] _namespaces_Accessibility = namespaces_Accessibility.Split(',');

            string namespaces_Microsoft_Activities = DotNetBrowser.APIs.Namespaces.Namespaces.Microsoft_Activities_Namespaces;
            string[] _namespaces_Microsoft_Activities = namespaces_Microsoft_Activities.Split(',');

            string namespaces_Microsoft_Build = DotNetBrowser.APIs.Namespaces.Namespaces.Microsoft_Build_Namespaces;
            string[] _namespaces_Microsoft_Build = namespaces_Microsoft_Build.Split(',');

            string namespaces_Microsoft_CSharp = DotNetBrowser.APIs.Namespaces.Namespaces.Microsoft_CSharp_Namespaces;
            string[] _namespaces_Microsoft_CSharp = namespaces_Microsoft_CSharp.Split(',');

            string namespaces_Microsoft_JScript = DotNetBrowser.APIs.Namespaces.Namespaces.Microsoft_JScript_Namespaces;
            string[] _namespaces_Microsoft_JScript = namespaces_Microsoft_JScript.Split(',');

            string namespaces_Microsoft_SqlServer = DotNetBrowser.APIs.Namespaces.Namespaces.Microsoft_SqlServer_Namespaces;
            string[] _namespaces_Microsoft_SqlServer = namespaces_Microsoft_SqlServer.Split(',');

            string namespaces_Microsoft_VisualBasic = DotNetBrowser.APIs.Namespaces.Namespaces.Microsoft_VisualBasic_Namespaces;
            string[] _namespaces_Microsoft_VisualBasic = namespaces_Microsoft_VisualBasic.Split(',');

            string namespaces_Microsoft_VisualC = DotNetBrowser.APIs.Namespaces.Namespaces.Microsoft_VisualC_Namespaces;
            string[] _namespaces_Microsoft_VisualC = namespaces_Microsoft_VisualC.Split(',');

            string namespaces_Microsoft_Win32 = DotNetBrowser.APIs.Namespaces.Namespaces.Microsoft_Win32_Namespaces;
            string[] _namespaces_Microsoft_Win32 = namespaces_Microsoft_Win32.Split(',');

            string namespaces_Microsoft_Windows = DotNetBrowser.APIs.Namespaces.Namespaces.Microsoft_Windows_Namespaces;
            string[] _namespaces_Microsoft_Windows = namespaces_Microsoft_Windows.Split(',');

            string namespaces_System = DotNetBrowser.APIs.Namespaces.Namespaces.System_Namespaces;
            string[] _namespaces_System = namespaces_System.Split(',');

            string namespaces_System_Activities = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_Namespaces;
            string[] _namespaces_System_Activities = namespaces_System_Activities.Split(',');

            string namespaces_System_Activities_Core = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_Core_Namespaces;
            string[] _namespaces_System_Activities_Core = namespaces_System_Activities_Core.Split(',');

            string namespaces_System_Activities_Debugger = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_Debugger_Namespaces;
            string[] _namespaces_System_Activities_Debugger = namespaces_System_Activities_Debugger.Split(',');

            string namespaces_System_Activities_DurableInstancing = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_DurableInstancing_Namespaces;
            string[] _namespaces_System_Activities_DurableInstancing = namespaces_System_Activities_DurableInstancing.Split(',');

            string namespaces_System_Activities_DynamicUpdate = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_DynamicUpdate_Namespaces;
            string[] _namespaces_System_Activities_DynamicUpdate = namespaces_System_Activities_DynamicUpdate.Split(',');

            string namespaces_System_Activities_ExpressionParser = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_ExpressionParser_Namespaces;
            string[] _namespaces_System_Activities_ExpressionParser = namespaces_System_Activities_ExpressionParser.Split(',');

            string namespaces_System_Activities_Expressions = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_Expressions_Namespaces;
            string[] _namespaces_System_Activities_Expressions = namespaces_System_Activities_Expressions.Split(',');

            string namespaces_System_Activities_Hosting = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_Hosting_Namespaces;
            string[] _namespaces_System_Activities_Hosting = namespaces_System_Activities_Hosting.Split(',');

            string namespaces_System_Activities_Persistence = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_Persistence_Namespaces;
            string[] _namespaces_System_Activities_Persistence = namespaces_System_Activities_Persistence.Split(',');

            string namespaces_System_Activities_Presentation = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_Presentation_Namespaces;
            string[] _namespaces_System_Activities_Presentation = namespaces_System_Activities_Presentation.Split(',');

            string namespaces_System_Activities_Statements = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_Statements_Namespaces;
            string[] _namespaces_System_Activities_Statements = namespaces_System_Activities_Statements.Split(',');

            string namespaces_System_Activities_Tracking = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_Tracking_Namespaces;
            string[] _namespaces_System_Activities_Tracking = namespaces_System_Activities_Tracking.Split(',');

            string namespaces_System_Activities_Validation = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_Validation_Namespaces;
            string[] _namespaces_System_Activities_Validation = namespaces_System_Activities_Validation.Split(',');

            string namespaces_System_Activities_XamlIntegration = DotNetBrowser.APIs.Namespaces.Namespaces.System_Activities_XamlIntegration_Namespaces;
            string[] _namespaces_System_Activities_XamlIntegration = namespaces_System_Activities_XamlIntegration.Split(',');

            string namespaces_System_AddIn = DotNetBrowser.APIs.Namespaces.Namespaces.System_AddIn_Namespaces;
            string[] _namespaces_System_AddIn = namespaces_System_AddIn.Split(',');

            string namespaces_System_CodeDom = DotNetBrowser.APIs.Namespaces.Namespaces.System_CodeDom_Namespaces;
            string[] _namespaces_System_CodeDom = namespaces_System_CodeDom.Split(',');

            string namespaces_System_Collections = DotNetBrowser.APIs.Namespaces.Namespaces.System_Collections_Namespaces;
            string[] _namespaces_System_Collections = namespaces_System_Collections.Split(',');

            string namespaces_System_ComponentModel = DotNetBrowser.APIs.Namespaces.Namespaces.System_ComponentModel_Namespaces;
            string[] _namespaces_System_ComponentModel = namespaces_System_ComponentModel.Split(',');

            string namespaces_System_ComponentModel_Composition = DotNetBrowser.APIs.Namespaces.Namespaces.System_ComponentModel_Composition_Namespaces;
            string[] _namespaces_System_ComponentModel_Composition = namespaces_System_ComponentModel_Composition.Split(',');

            string namespaces_System_ComponentModel_DataAnnotations = DotNetBrowser.APIs.Namespaces.Namespaces.System_ComponentModel_DataAnnotations_Namespaces;
            string[] _namespaces_System_ComponentModel_DataAnnotations = namespaces_System_ComponentModel_DataAnnotations.Split(',');

            string namespaces_System_ComponentModel_Design = DotNetBrowser.APIs.Namespaces.Namespaces.System_ComponentModel_Design_Namespaces;
            string[] _namespaces_System_ComponentModel_Design = namespaces_System_ComponentModel_Design.Split(',');

            #endregion Namespaces

            #region Classes

            string classes_Accessability = DotNetBrowser.APIs.Classes.Classes.Accessibility_ClassName;
            //string[] _classes_Accessability = classes_Accessability.Split(',');

            #endregion Classes

            #endregion Variabledefinitions

            #region Generate Namespaces Lists

            var list = new List<string>();
            list.AddRange(_namespaces_Accessibility);
            string[] Accessibility_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_Microsoft_Activities);
            string[] Microsoft_Activites_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_Microsoft_Build);
            string[] Microsoft_Build_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_Microsoft_CSharp);
            string[] Microsoft_CSharp_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_Microsoft_JScript);
            string[] Microsoft_JSCript_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_Microsoft_SqlServer);
            string[] Microsoft_SqlServer_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_Microsoft_VisualBasic);
            string[] Microsoft_VisualBasic_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_Microsoft_VisualC);
            string[] Microsoft_VisualC_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_Microsoft_Win32);
            string[] Microsoft_Win32_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_Microsoft_Windows);
            string[] Microsoft_Windows_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System);
            string[] System_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities);
            string[] System_Activities_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities_Core);
            string[] System_Activities_Core_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities_Debugger);
            string[] System_Activities_Debugger_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities_DurableInstancing);
            string[] System_Activities_DurableInstancing_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities_DynamicUpdate);
            string[] System_Activities_DynamicUpdate_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities_ExpressionParser);
            string[] System_Activities_ExpressionParser_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities_Expressions);
            string[] System_Activities_Expressions_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities_Hosting);
            string[] System_Activities_Hosting_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities_Persistence);
            string[] System_Activities_Persistence_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities_Presentation);
            string[] System_Activities_Presentation_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities_Statements);
            string[] System_Activities_Statements_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities_Tracking);
            string[] System_Activities_Tracking_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities_Validation);
            string[] System_Activities_Validation_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Activities_XamlIntegration);
            string[] System_Activities_XamlIntegration_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_AddIn);
            string[] System_AddIn_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_CodeDom);
            string[] System_CodeDom_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_Collections);
            string[] System_Collections_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_ComponentModel);
            string[] System_ComponentModel_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_ComponentModel_Composition);
            string[] System_ComponentModel_Composition_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_ComponentModel_DataAnnotations);
            string[] System_ComponentModel_DataAnnotations_namespaces = list.ToArray();

            list.Clear();
            list.AddRange(_namespaces_System_ComponentModel_Design);
            string[] System_ComponentModel_Design_namespaces = list.ToArray();

            #endregion Generate Namespaces Lists

            #region Generate Classes Lists

            /*
            var classList = new List<string>();
            classList.AddRange(_classes_Accessability);
            string[] Accessability_classes = classList.ToArray();
            */

            #endregion Generate Classes Lists

            #region Generate Namespaces and add to array

            Namespaces_Classes.Items.Clear();

            foreach(string apiNamespace in Accessibility_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in Microsoft_Activites_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in Microsoft_Build_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in Microsoft_CSharp_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in Microsoft_JSCript_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in Microsoft_SqlServer_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in Microsoft_VisualBasic_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in Microsoft_VisualC_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in Microsoft_Win32_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in Microsoft_Windows_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_Core_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_Debugger_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_DurableInstancing_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_DynamicUpdate_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_ExpressionParser_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_Expressions_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_Hosting_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_Persistence_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_Presentation_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_Statements_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_Tracking_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_Validation_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Activities_XamlIntegration_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_AddIn_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_CodeDom_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_Collections_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_ComponentModel_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_ComponentModel_Composition_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_ComponentModel_DataAnnotations_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            foreach (string apiNamespace in System_ComponentModel_Design_namespaces)
            {
                Namespace newApiNamespace = new Namespace(apiNamespace);
                listNamespaces.Add(newApiNamespace);
            }

            #endregion Generate Namespaces and add to array

            #region Generate Classes and add to array

            /*
            foreach (string apiNamespaceClass in Accessability_classes)
            {
                Class newApiNamespaceClass = new Class(apiNamespaceClass);
                listClasses.Add(newApiNamespaceClass);
            }
            */

            #endregion Generate Classes and add to array

            #region Instanciate new RootNode

            var apiNamespaces = new RootNode("Namespaces")
            {
                //
            };

            #endregion Instanciate new RootNode

            #region Fill TreeView

            foreach (Namespace apiNamespace in listNamespaces)
            {
                apiNamespaces.RootNodes.Add(apiNamespace);
            }

            /*
            int classCounter = 0;
            foreach (Namespace apiNamespace in apiNamespaces.RootNodes)
            {
                apiNamespace.Classes.Add(listClasses[classCounter]);
                //classCounter++;
            }
            */

            var globalNamespace = new Collection<RootNode>()
            {
                apiNamespaces
            };

            DataContext = new
            {
                ApiNamespaces = apiNamespaces,
                GlobalNamespace = globalNamespace
            };

            #endregion Fill TreeView
        }

        private void OnPreviewMouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            #region Variable definition

            string[] classNames;
            string[] classDescriptions;

            string[] structNames;
            string[] structDescriptions;

            string[] interfaceNames;
            string[] interfaceDescriptions;

            string[] enumNames;
            string[] enumDescriptions;

            string[] delegateNames;
            string[] delegateDescriptions;

            int classCounter = 0;
            int structCounter = 0;
            int interfaceCounter = 0;
            int enumCounter = 0;
            int delegateCounter = 0;

            TextBlock tvi = e.OriginalSource as TextBlock;
            List<Class> listClasses = new List<Class>();
            List<Struct> listStructs = new List<Struct>();
            List<Interface> listInterfaces = new List<Interface>();
            List<Enum> listEnums = new List<Enum>();
            List<Delegate> listDelegates = new List<Delegate>();

            #endregion Variable definition

            if (tvi != null && tvi.Text != "Namespaces")
            {
                Text_Headline.Text = tvi.Text + " Namespace";
                Text_Description.Text = DotNetBrowser.APIs.Namespaces.Descriptions.ResourceManager.GetString(tvi.Text + "_NamespaceDescription").ToString();

                #region Classes table

                try
                {
                    classNames = DotNetBrowser.APIs.Classes.Classes.ResourceManager.GetString(tvi.Text + "_ClassName").Split('^');
                }
                catch (NullReferenceException)
                {
                    classNames = null;
                }
                try
                {
                    classDescriptions = DotNetBrowser.APIs.Classes.Descriptions.ResourceManager.GetString(tvi.Text + "_ClassDescription").Split('^');
                }
                catch (NullReferenceException)
                {
                    classDescriptions = null;
                }

                if (classNames != null)
                {
                    Text_Classes.Visibility = Visibility.Visible;
                    GridView_Classes.Visibility = Visibility.Visible;

                    foreach (string className in classNames)
                    {
                        Class apiClass = new Class(className, classDescriptions[classCounter]);
                        listClasses.Add(apiClass);
                        classCounter++;
                    }
                }
                else
                {
                    Text_Classes.Visibility = Visibility.Collapsed;
                    GridView_Classes.Visibility = Visibility.Collapsed;
                }

                #endregion Classes table

                #region Structs table

                try
                {
                    structNames = DotNetBrowser.APIs.Structs.Structs.ResourceManager.GetString(tvi.Text + "_StructName").Split('^');
                }
                catch(NullReferenceException)
                {
                    structNames = null;
                }
                try
                {
                    structDescriptions = DotNetBrowser.APIs.Structs.Descriptions.ResourceManager.GetString(tvi.Text + "_StructDescription").Split('^');
                }
                catch (NullReferenceException)
                {
                    structDescriptions = null;
                }

                if (structNames != null)
                {
                    Text_Structs.Visibility = Visibility.Visible;
                    GridView_Structs.Visibility = Visibility.Visible;

                    foreach (string structName in structNames)
                    {
                        Struct apiStruct = new Struct(structName, structDescriptions[structCounter]);
                        listStructs.Add(apiStruct);
                        structCounter++;
                    }
                }
                else
                {
                    Text_Structs.Visibility = Visibility.Collapsed;
                    GridView_Structs.Visibility = Visibility.Collapsed;
                }

                #endregion Structs table

                #region Interfaces table

                try
                {
                    interfaceNames = DotNetBrowser.APIs.Interfaces.Interfaces.ResourceManager.GetString(tvi.Text + "_InterfaceName").Split('^');
                }
                catch (NullReferenceException)
                {
                    interfaceNames = null;
                }
                try
                {
                    interfaceDescriptions = DotNetBrowser.APIs.Interfaces.Descriptions.ResourceManager.GetString(tvi.Text + "_InterfaceDescription").Split('^');
                }
                catch (NullReferenceException)
                {
                    interfaceDescriptions = null;
                }

                if (interfaceNames != null)
                {
                    Text_Interfaces.Visibility = Visibility.Visible;
                    GridView_Interfaces.Visibility = Visibility.Visible;

                    foreach (string interfaceName in interfaceNames)
                    {
                        Interface apiInterface = new Interface(interfaceName, interfaceDescriptions[interfaceCounter]);
                        listInterfaces.Add(apiInterface);
                        interfaceCounter++;
                    }
                }
                else
                {
                    Text_Interfaces.Visibility = Visibility.Collapsed;
                    GridView_Interfaces.Visibility = Visibility.Collapsed;
                }

                #endregion Interfaces table

                #region Enums table

                try
                {
                    enumNames = DotNetBrowser.APIs.Enums.Enums.ResourceManager.GetString(tvi.Text + "_EnumName").Split('^');
                }
                catch (NullReferenceException)
                {
                    enumNames = null;
                }
                try
                {
                    enumDescriptions = DotNetBrowser.APIs.Enums.Descriptions.ResourceManager.GetString(tvi.Text + "_EnumDescription").Split('^');
                }
                catch (NullReferenceException)
                {
                    enumDescriptions = null;
                }

                if (enumNames != null)
                {
                    Text_Enums.Visibility = Visibility.Visible;
                    GridView_Enums.Visibility = Visibility.Visible;

                    foreach (string enumName in enumNames)
                    {
                        Enum apiEnum = new Enum(enumName, enumDescriptions[enumCounter]);
                        listEnums.Add(apiEnum);
                        enumCounter++;
                    }
                }
                else
                {
                    Text_Enums.Visibility = Visibility.Collapsed;
                    GridView_Enums.Visibility = Visibility.Collapsed;
                }

                #endregion Enums table

                #region Delegates table

                try
                {
                    delegateNames = DotNetBrowser.APIs.Delegates.Delegates.ResourceManager.GetString(tvi.Text + "_DelegateName").Split('^');
                }
                catch (NullReferenceException)
                {
                    delegateNames = null;
                }
                try
                {
                    delegateDescriptions = DotNetBrowser.APIs.Delegates.Descriptions.ResourceManager.GetString(tvi.Text + "_DelegateDescription").Split('^');
                }
                catch (NullReferenceException)
                {
                    delegateDescriptions = null;
                }

                if (delegateNames != null)
                {
                    Text_Delegates.Visibility = Visibility.Visible;
                    GridView_Delegates.Visibility = Visibility.Visible;

                    foreach (string delegateName in delegateNames)
                    {
                        Delegate apiDelegate = new Delegate(delegateName, delegateDescriptions[delegateCounter]);
                        listDelegates.Add(apiDelegate);
                        delegateCounter++;
                    }
                }
                else
                {
                    Text_Delegates.Visibility = Visibility.Collapsed;
                    GridView_Delegates.Visibility = Visibility.Collapsed;
                }

                #endregion Delegates table

                #region Add lists to GridView

                GridView_Classes.ItemsSource = listClasses;
                GridView_Structs.ItemsSource = listStructs;
                GridView_Interfaces.ItemsSource = listInterfaces;
                GridView_Enums.ItemsSource = listEnums;
                GridView_Delegates.ItemsSource = listDelegates;

                #endregion Add lists to GridView
            }
            else
            {
                Text_Headline.Text = "Welcome to DotNetBrowser";
                Text_Description.Text = "Start with browsing the tree on the left side.";

                Text_Classes.Visibility = Visibility.Hidden;
                GridView_Classes.Visibility = Visibility.Hidden;
                GridView_Classes.ItemsSource = null;

                Text_Structs.Visibility = Visibility.Hidden;
                GridView_Structs.Visibility = Visibility.Hidden;
                GridView_Structs.ItemsSource = null;

                Text_Interfaces.Visibility = Visibility.Hidden;
                GridView_Interfaces.Visibility = Visibility.Hidden;
                GridView_Interfaces.ItemsSource = null;

                Text_Enums.Visibility = Visibility.Hidden;
                GridView_Enums.Visibility = Visibility.Hidden;
                GridView_Enums.ItemsSource = null;

                Text_Delegates.Visibility = Visibility.Hidden;
                GridView_Delegates.Visibility = Visibility.Hidden;
                GridView_Delegates.ItemsSource = null;
            }
        }

        public class RootNode
        {
            public RootNode(string name)
            {
                Name = name;
                RootNodes = new ObservableCollection<Namespace>();
            }

            public string Name { get; private set; }
            public ObservableCollection<Namespace> RootNodes { get; private set; }
        }

        public class Namespace
        {
            public Namespace(string name)
            {
                Name = name;
                Classes = new ObservableCollection<Class>();
            }

            public string Name { get; private set; }
            public ObservableCollection<Class> Classes { get; private set; }
        }

        public class Class
        {
            public Class(string name, string description)
            {
                Name = name;
                Description = description;
            }
            public string Name { get; private set; }
            public string Description { get; private set; }
        }

        public class Struct
        {
            public Struct(string name, string description)
            {
                Name = name;
                Description = description;
            }
            public string Name { get; private set; }
            public string Description { get; private set; }
        }

        public class Interface
        {
            public Interface(string name, string description)
            {
                Name = name;
                Description = description;
            }
            public string Name { get; private set; }
            public string Description { get; private set; }
        }

        public class Enum
        {
            public Enum(string name, string description)
            {
                Name = name;
                Description = description;
            }
            public string Name { get; private set; }
            public string Description { get; private set; }
        }

        public class Delegate
        {
            public Delegate(string name, string description)
            {
                Name = name;
                Description = description;
            }
            public string Name { get; private set; }
            public string Description { get; private set; }
        }
    }
}
