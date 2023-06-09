﻿///////////////////////////////////////////////////////////////////////////////
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

namespace RMJ
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the RMJRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("5eaa6e3d-1c27-4a17-b71c-9c3d6c91ca2c")]
    public partial class RMJRepository : RepoGenBaseFolder
    {
        static RMJRepository instance = new RMJRepository();
        RMJRepositoryFolders.RxMainFrameAppFolder _rxmainframe;

        /// <summary>
        /// Gets the singleton class instance representing the RMJRepository element repository.
        /// </summary>
        [RepositoryFolder("5eaa6e3d-1c27-4a17-b71c-9c3d6c91ca2c")]
        public static RMJRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public RMJRepository() 
            : base("RMJRepository", "/", null, 0, false, "5eaa6e3d-1c27-4a17-b71c-9c3d6c91ca2c", ".\\RepositoryImages\\RMJRepository5eaa6e3d.rximgres")
        {
            _rxmainframe = new RMJRepositoryFolders.RxMainFrameAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("5eaa6e3d-1c27-4a17-b71c-9c3d6c91ca2c")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("6a58976b-2ee2-49a3-a654-8c5f02a44f76")]
        public virtual RMJRepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class RMJRepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("6a58976b-2ee2-49a3-a654-8c5f02a44f76")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _enteryournameInfo;
            RepoItemInfo _btnsubmitusernameInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@title>'Ranorex Studio Demo Appli']", parentFolder, 30000, null, true, "6a58976b-2ee2-49a3-a654-8c5f02a44f76", "")
            {
                _enteryournameInfo = new RepoItemInfo(this, "EnterYourName", "?/?/tabpage[@index='0' and @controlname='RxTabIntroduction']/?/?/text[@accessiblename='Enter your name']", ".//text[@accessiblename='Enter your name']", 30000, null, "827782ac-4137-4ed7-88ba-c21ff7b15df5");
                _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", "?/?/tabpage[@index='0' and @controlname='RxTabIntroduction']/button[@text='Submit']", ".//button[@text='Submit']", 30000, null, "47087829-49a2-487c-870e-6eba55148f67");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6a58976b-2ee2-49a3-a654-8c5f02a44f76")]
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
            [RepositoryItemInfo("6a58976b-2ee2-49a3-a654-8c5f02a44f76")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The EnterYourName item.
            /// </summary>
            [RepositoryItem("827782ac-4137-4ed7-88ba-c21ff7b15df5")]
            public virtual Ranorex.Text EnterYourName
            {
                get
                {
                    return _enteryournameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EnterYourName item info.
            /// </summary>
            [RepositoryItemInfo("827782ac-4137-4ed7-88ba-c21ff7b15df5")]
            public virtual RepoItemInfo EnterYourNameInfo
            {
                get
                {
                    return _enteryournameInfo;
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item.
            /// </summary>
            [RepositoryItem("47087829-49a2-487c-870e-6eba55148f67")]
            public virtual Ranorex.Button BtnSubmitUserName
            {
                get
                {
                    return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item info.
            /// </summary>
            [RepositoryItemInfo("47087829-49a2-487c-870e-6eba55148f67")]
            public virtual RepoItemInfo BtnSubmitUserNameInfo
            {
                get
                {
                    return _btnsubmitusernameInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
