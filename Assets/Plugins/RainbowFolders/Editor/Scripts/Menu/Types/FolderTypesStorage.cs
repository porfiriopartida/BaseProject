/*
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using UnityEngine;
using EditorUtility = Plugins.RainbowFolders.Editor.Scripts.Helpers.RainbowFoldersEditorUtility;

namespace Plugins.RainbowFolders.Editor.Scripts.Menu.Types
{
    public class FolderTypesStorage : ScriptableObject
    {
        private const string RELATIVE_PATH = "Editor/Data/FolderTypesStorage.asset";

        public List<FolderType> TypeFolderIcons;

        //---------------------------------------------------------------------
        // Instance
        //---------------------------------------------------------------------

        private static FolderTypesStorage _instance;

        [SuppressMessage("ReSharper", "ConvertIfStatementToNullCoalescingExpression")]
        public static FolderTypesStorage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = EditorUtility.LoadFromAsset<FolderTypesStorage>(RELATIVE_PATH);

                return _instance;
            }
        }

        //---------------------------------------------------------------------
        // Public
        //---------------------------------------------------------------------

        public FolderIconPair GetIconsByType(FolderTypeName type)
        {
            var colorFolder = TypeFolderIcons.Single(x => x.Type == type);
            return new FolderIconPair { SmallIcon = colorFolder.SmallIcon, LargeIcon = colorFolder.LargeIcon };
        }
    }
}
