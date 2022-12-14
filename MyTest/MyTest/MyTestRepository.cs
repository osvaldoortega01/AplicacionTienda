///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("2a8e20fa-f677-4251-b480-71ab19ae6d70")]
    public partial class MyTestRepository : RepoGenBaseFolder
    {
        static MyTestRepository instance = new MyTestRepository();
        MyTestRepositoryFolders.LogInAppFolder _login;
        MyTestRepositoryFolders.AplicacionTiendaAppFolder _aplicaciontienda;
        MyTestRepositoryFolders.MenuPrincipalAdminAppFolder _menuprincipaladmin;
        MyTestRepositoryFolders.List1000AppFolder _list1000;
        MyTestRepositoryFolders.AvisoAppFolder _aviso;

        /// <summary>
        /// Gets the singleton class instance representing the MyTestRepository element repository.
        /// </summary>
        [RepositoryFolder("2a8e20fa-f677-4251-b480-71ab19ae6d70")]
        public static MyTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTestRepository() 
            : base("MyTestRepository", "/", null, 0, false, "2a8e20fa-f677-4251-b480-71ab19ae6d70", ".\\RepositoryImages\\MyTestRepository2a8e20fa.rximgres")
        {
            _login = new MyTestRepositoryFolders.LogInAppFolder(this);
            _aplicaciontienda = new MyTestRepositoryFolders.AplicacionTiendaAppFolder(this);
            _menuprincipaladmin = new MyTestRepositoryFolders.MenuPrincipalAdminAppFolder(this);
            _list1000 = new MyTestRepositoryFolders.List1000AppFolder(this);
            _aviso = new MyTestRepositoryFolders.AvisoAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("2a8e20fa-f677-4251-b480-71ab19ae6d70")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The LogIn folder.
        /// </summary>
        [RepositoryFolder("a4763e5a-fd31-465e-93b4-d1d3a46c924c")]
        public virtual MyTestRepositoryFolders.LogInAppFolder LogIn
        {
            get { return _login; }
        }

        /// <summary>
        /// The AplicacionTienda folder.
        /// </summary>
        [RepositoryFolder("0d0aaf31-a184-4070-abf7-b847b566c2a6")]
        public virtual MyTestRepositoryFolders.AplicacionTiendaAppFolder AplicacionTienda
        {
            get { return _aplicaciontienda; }
        }

        /// <summary>
        /// The MenuPrincipalAdmin folder.
        /// </summary>
        [RepositoryFolder("dec2180f-c8fb-4d45-a78a-363d53ac5346")]
        public virtual MyTestRepositoryFolders.MenuPrincipalAdminAppFolder MenuPrincipalAdmin
        {
            get { return _menuprincipaladmin; }
        }

        /// <summary>
        /// The List1000 folder.
        /// </summary>
        [RepositoryFolder("444e49f9-2a6c-4cbe-a837-90b2997c1b11")]
        public virtual MyTestRepositoryFolders.List1000AppFolder List1000
        {
            get { return _list1000; }
        }

        /// <summary>
        /// The Aviso folder.
        /// </summary>
        [RepositoryFolder("18318664-97bf-4563-bf6c-6d3f22842cae")]
        public virtual MyTestRepositoryFolders.AvisoAppFolder Aviso
        {
            get { return _aviso; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTestRepositoryFolders
    {
        /// <summary>
        /// The LogInAppFolder folder.
        /// </summary>
        [RepositoryFolder("a4763e5a-fd31-465e-93b4-d1d3a46c924c")]
        public partial class LogInAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _textInfo;
            RepoItemInfo _cbisadminInfo;
            RepoItemInfo _btnloginInfo;

            /// <summary>
            /// Creates a new LogIn  folder.
            /// </summary>
            public LogInAppFolder(RepoGenBaseFolder parentFolder) :
                    base("LogIn", "/form[@controlname='LogIn']", parentFolder, 30000, null, true, "a4763e5a-fd31-465e-93b4-d1d3a46c924c", "")
            {
                _textInfo = new RepoItemInfo(this, "Text", "?/?/text[@accessiblerole='Text']", "?/?/text[@accessiblerole='Text']", 30000, null, "9dc5e0de-7143-4ff8-b0c9-62e2a92d005a");
                _cbisadminInfo = new RepoItemInfo(this, "CbIsAdmin", "checkbox[@text='¿Es administrador?']", "checkbox[@text='¿Es administrador?']", 30000, null, "f3fc0eab-e82b-4698-bb5e-8a321667cdb2");
                _btnloginInfo = new RepoItemInfo(this, "BtnLogin", "button[@text='Iniciar Sesión']", "button[@text='Iniciar Sesión']", 30000, null, "603cd444-93d3-4ba6-8db5-73c557597a30");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a4763e5a-fd31-465e-93b4-d1d3a46c924c")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a4763e5a-fd31-465e-93b4-d1d3a46c924c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("9dc5e0de-7143-4ff8-b0c9-62e2a92d005a")]
            public virtual Ranorex.Text Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("9dc5e0de-7143-4ff8-b0c9-62e2a92d005a")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The CbIsAdmin item.
            /// </summary>
            [RepositoryItem("f3fc0eab-e82b-4698-bb5e-8a321667cdb2")]
            public virtual Ranorex.CheckBox CbIsAdmin
            {
                get
                {
                    return _cbisadminInfo.CreateAdapter<Ranorex.CheckBox>(true);
                }
            }

            /// <summary>
            /// The CbIsAdmin item info.
            /// </summary>
            [RepositoryItemInfo("f3fc0eab-e82b-4698-bb5e-8a321667cdb2")]
            public virtual RepoItemInfo CbIsAdminInfo
            {
                get
                {
                    return _cbisadminInfo;
                }
            }

            /// <summary>
            /// The BtnLogin item.
            /// </summary>
            [RepositoryItem("603cd444-93d3-4ba6-8db5-73c557597a30")]
            public virtual Ranorex.Button BtnLogin
            {
                get
                {
                    return _btnloginInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnLogin item info.
            /// </summary>
            [RepositoryItemInfo("603cd444-93d3-4ba6-8db5-73c557597a30")]
            public virtual RepoItemInfo BtnLoginInfo
            {
                get
                {
                    return _btnloginInfo;
                }
            }
        }

        /// <summary>
        /// The AplicacionTiendaAppFolder folder.
        /// </summary>
        [RepositoryFolder("0d0aaf31-a184-4070-abf7-b847b566c2a6")]
        public partial class AplicacionTiendaAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonokInfo;

            /// <summary>
            /// Creates a new AplicacionTienda  folder.
            /// </summary>
            public AplicacionTiendaAppFolder(RepoGenBaseFolder parentFolder) :
                    base("AplicacionTienda", "/form[@title='AplicacionTienda']", parentFolder, 30000, null, true, "0d0aaf31-a184-4070-abf7-b847b566c2a6", "")
            {
                _buttonokInfo = new RepoItemInfo(this, "ButtonOK", "button[@text='OK']", "button[@text='OK']", 30000, null, "96fa77d4-d36c-4b6f-81fd-b4432a4c4af9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("0d0aaf31-a184-4070-abf7-b847b566c2a6")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("0d0aaf31-a184-4070-abf7-b847b566c2a6")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonOK item.
            /// </summary>
            [RepositoryItem("96fa77d4-d36c-4b6f-81fd-b4432a4c4af9")]
            public virtual Ranorex.Button ButtonOK
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK item info.
            /// </summary>
            [RepositoryItemInfo("96fa77d4-d36c-4b6f-81fd-b4432a4c4af9")]
            public virtual RepoItemInfo ButtonOKInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }
        }

        /// <summary>
        /// The MenuPrincipalAdminAppFolder folder.
        /// </summary>
        [RepositoryFolder("dec2180f-c8fb-4d45-a78a-363d53ac5346")]
        public partial class MenuPrincipalAdminAppFolder : RepoGenBaseFolder
        {
            MyTestRepositoryFolders.AgregarUsuario1Folder _agregarusuario1;
            RepoItemInfo _paneldesktopInfo;
            RepoItemInfo _btnadduserInfo;

            /// <summary>
            /// Creates a new MenuPrincipalAdmin  folder.
            /// </summary>
            public MenuPrincipalAdminAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MenuPrincipalAdmin", "/form[@controlname='MenuPrincipalAdmin']", parentFolder, 30000, null, true, "dec2180f-c8fb-4d45-a78a-363d53ac5346", "")
            {
                _agregarusuario1 = new MyTestRepositoryFolders.AgregarUsuario1Folder(this);
                _paneldesktopInfo = new RepoItemInfo(this, "PanelDesktop", "container[@automationid='PanelDesktop']", "container[@automationid='PanelDesktop']", 30000, null, "70c0dffd-a6d4-49f8-975d-11e458d99281");
                _btnadduserInfo = new RepoItemInfo(this, "BtnAddUser", "?/?/form[@controlname='ConsultaUsuarios']/button[@text='Agregar Usuario']", ".//button[@text='Agregar Usuario']", 30000, null, "4b22034b-fade-4bb8-9af5-52642916d6a6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("dec2180f-c8fb-4d45-a78a-363d53ac5346")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("dec2180f-c8fb-4d45-a78a-363d53ac5346")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The PanelDesktop item.
            /// </summary>
            [RepositoryItem("70c0dffd-a6d4-49f8-975d-11e458d99281")]
            public virtual Ranorex.Container PanelDesktop
            {
                get
                {
                    return _paneldesktopInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The PanelDesktop item info.
            /// </summary>
            [RepositoryItemInfo("70c0dffd-a6d4-49f8-975d-11e458d99281")]
            public virtual RepoItemInfo PanelDesktopInfo
            {
                get
                {
                    return _paneldesktopInfo;
                }
            }

            /// <summary>
            /// The BtnAddUser item.
            /// </summary>
            [RepositoryItem("4b22034b-fade-4bb8-9af5-52642916d6a6")]
            public virtual Ranorex.Button BtnAddUser
            {
                get
                {
                    return _btnadduserInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnAddUser item info.
            /// </summary>
            [RepositoryItemInfo("4b22034b-fade-4bb8-9af5-52642916d6a6")]
            public virtual RepoItemInfo BtnAddUserInfo
            {
                get
                {
                    return _btnadduserInfo;
                }
            }

            /// <summary>
            /// The AgregarUsuario1 folder.
            /// </summary>
            [RepositoryFolder("a0383850-4e9b-4296-9719-58eabe7fb923")]
            public virtual MyTestRepositoryFolders.AgregarUsuario1Folder AgregarUsuario1
            {
                get { return _agregarusuario1; }
            }
        }

        /// <summary>
        /// The AgregarUsuario1Folder folder.
        /// </summary>
        [RepositoryFolder("a0383850-4e9b-4296-9719-58eabe7fb923")]
        public partial class AgregarUsuario1Folder : RepoGenBaseFolder
        {
            RepoItemInfo _agregarusuarioInfo;
            RepoItemInfo _direccionInfo;
            RepoItemInfo _nombreInfo;
            RepoItemInfo _tipoInfo;
            RepoItemInfo _btnaddInfo;

            /// <summary>
            /// Creates a new AgregarUsuario1  folder.
            /// </summary>
            public AgregarUsuario1Folder(RepoGenBaseFolder parentFolder) :
                    base("AgregarUsuario1", "?/?/form[@controlname='AgregarUsuario']", parentFolder, 30000, null, false, "a0383850-4e9b-4296-9719-58eabe7fb923", "")
            {
                _agregarusuarioInfo = new RepoItemInfo(this, "AgregarUsuario", "", "", 30000, null, "d2db2d58-1cf2-4538-a7f2-241cc23aec8b");
                _direccionInfo = new RepoItemInfo(this, "Direccion", "?/?/text[@accessiblename='Dirección']", "", 30000, null, "2dec0ce5-ca2a-4d95-b8da-577253149cd3");
                _nombreInfo = new RepoItemInfo(this, "Nombre", "?/?/text[@accessiblename='Nombre']", "", 30000, null, "9699e506-b63f-4220-b887-8e4febb739c2");
                _tipoInfo = new RepoItemInfo(this, "Tipo", "?/?/text[@accessiblename='Tipo']", "", 30000, null, "e3cd1a46-1e1e-46d5-b065-07a01cfd5aee");
                _btnaddInfo = new RepoItemInfo(this, "BtnAdd", "button[@text='Agregar Usuario']", "", 30000, null, "6df26a50-8fed-488d-a695-225c8117616d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a0383850-4e9b-4296-9719-58eabe7fb923")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a0383850-4e9b-4296-9719-58eabe7fb923")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The AgregarUsuario item.
            /// </summary>
            [RepositoryItem("d2db2d58-1cf2-4538-a7f2-241cc23aec8b")]
            public virtual Ranorex.Form AgregarUsuario
            {
                get
                {
                    return _agregarusuarioInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The AgregarUsuario item info.
            /// </summary>
            [RepositoryItemInfo("d2db2d58-1cf2-4538-a7f2-241cc23aec8b")]
            public virtual RepoItemInfo AgregarUsuarioInfo
            {
                get
                {
                    return _agregarusuarioInfo;
                }
            }

            /// <summary>
            /// The Direccion item.
            /// </summary>
            [RepositoryItem("2dec0ce5-ca2a-4d95-b8da-577253149cd3")]
            public virtual Ranorex.Text Direccion
            {
                get
                {
                    return _direccionInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Direccion item info.
            /// </summary>
            [RepositoryItemInfo("2dec0ce5-ca2a-4d95-b8da-577253149cd3")]
            public virtual RepoItemInfo DireccionInfo
            {
                get
                {
                    return _direccionInfo;
                }
            }

            /// <summary>
            /// The Nombre item.
            /// </summary>
            [RepositoryItem("9699e506-b63f-4220-b887-8e4febb739c2")]
            public virtual Ranorex.Text Nombre
            {
                get
                {
                    return _nombreInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Nombre item info.
            /// </summary>
            [RepositoryItemInfo("9699e506-b63f-4220-b887-8e4febb739c2")]
            public virtual RepoItemInfo NombreInfo
            {
                get
                {
                    return _nombreInfo;
                }
            }

            /// <summary>
            /// The Tipo item.
            /// </summary>
            [RepositoryItem("e3cd1a46-1e1e-46d5-b065-07a01cfd5aee")]
            public virtual Ranorex.Text Tipo
            {
                get
                {
                    return _tipoInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Tipo item info.
            /// </summary>
            [RepositoryItemInfo("e3cd1a46-1e1e-46d5-b065-07a01cfd5aee")]
            public virtual RepoItemInfo TipoInfo
            {
                get
                {
                    return _tipoInfo;
                }
            }

            /// <summary>
            /// The BtnAdd item.
            /// </summary>
            [RepositoryItem("6df26a50-8fed-488d-a695-225c8117616d")]
            public virtual Ranorex.Button BtnAdd
            {
                get
                {
                    return _btnaddInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnAdd item info.
            /// </summary>
            [RepositoryItemInfo("6df26a50-8fed-488d-a695-225c8117616d")]
            public virtual RepoItemInfo BtnAddInfo
            {
                get
                {
                    return _btnaddInfo;
                }
            }
        }

        /// <summary>
        /// The List1000AppFolder folder.
        /// </summary>
        [RepositoryFolder("444e49f9-2a6c-4cbe-a837-90b2997c1b11")]
        public partial class List1000AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _adminInfo;

            /// <summary>
            /// Creates a new List1000  folder.
            /// </summary>
            public List1000AppFolder(RepoGenBaseFolder parentFolder) :
                    base("List1000", "/list[@automationid='ListBox']", parentFolder, 30000, null, true, "444e49f9-2a6c-4cbe-a837-90b2997c1b11", "")
            {
                _adminInfo = new RepoItemInfo(this, "ADMIN", "listitem[@text='ADMIN']", "listitem[@text='ADMIN']", 30000, null, "a179cac6-b9ec-426b-992a-4ed1cf7419ed");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("444e49f9-2a6c-4cbe-a837-90b2997c1b11")]
            public virtual Ranorex.List Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("444e49f9-2a6c-4cbe-a837-90b2997c1b11")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ADMIN item.
            /// </summary>
            [RepositoryItem("a179cac6-b9ec-426b-992a-4ed1cf7419ed")]
            public virtual Ranorex.ListItem ADMIN
            {
                get
                {
                    return _adminInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The ADMIN item info.
            /// </summary>
            [RepositoryItemInfo("a179cac6-b9ec-426b-992a-4ed1cf7419ed")]
            public virtual RepoItemInfo ADMINInfo
            {
                get
                {
                    return _adminInfo;
                }
            }
        }

        /// <summary>
        /// The AvisoAppFolder folder.
        /// </summary>
        [RepositoryFolder("18318664-97bf-4563-bf6c-6d3f22842cae")]
        public partial class AvisoAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonokInfo;

            /// <summary>
            /// Creates a new Aviso  folder.
            /// </summary>
            public AvisoAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Aviso", "/form[@title='Aviso']", parentFolder, 30000, null, true, "18318664-97bf-4563-bf6c-6d3f22842cae", "")
            {
                _buttonokInfo = new RepoItemInfo(this, "ButtonOK", "button[@text='OK']", "button[@text='OK']", 30000, null, "f7e9a335-cfa1-4ded-9fd5-4c93041da6a9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("18318664-97bf-4563-bf6c-6d3f22842cae")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("18318664-97bf-4563-bf6c-6d3f22842cae")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonOK item.
            /// </summary>
            [RepositoryItem("f7e9a335-cfa1-4ded-9fd5-4c93041da6a9")]
            public virtual Ranorex.Button ButtonOK
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK item info.
            /// </summary>
            [RepositoryItemInfo("f7e9a335-cfa1-4ded-9fd5-4c93041da6a9")]
            public virtual RepoItemInfo ButtonOKInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
