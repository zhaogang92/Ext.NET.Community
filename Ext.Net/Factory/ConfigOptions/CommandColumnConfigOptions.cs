/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 2.0.0.beta3 - Community Edition (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-05-28
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CommandColumn
    {
        /// <summary>
        /// 
        /// </summary>
		[Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                
                list.Add("hideable", new ConfigOption("hideable", null, false, this.Hideable ));
                list.Add("menuDisabled", new ConfigOption("menuDisabled", null, true, this.MenuDisabled ));
                list.Add("overOnly", new ConfigOption("overOnly", null, false, this.OverOnly ));
                list.Add("showDelay", new ConfigOption("showDelay", null, 250, this.ShowDelay ));
                list.Add("hideDelay", new ConfigOption("hideDelay", null, 500, this.HideDelay ));
                list.Add("commands", new ConfigOption("commands", new SerializationOptions("commands", JsonMode.AlwaysArray), null, this.Commands ));
                list.Add("groupCommands", new ConfigOption("groupCommands", new SerializationOptions("groupCommands", JsonMode.AlwaysArray), null, this.GroupCommands ));
                list.Add("prepareToolbar", new ConfigOption("prepareToolbar", new SerializationOptions(JsonMode.Raw), null, this.PrepareToolbar ));
                list.Add("prepareGroupToolbar", new ConfigOption("prepareGroupToolbar", new SerializationOptions(JsonMode.Raw), null, this.PrepareGroupToolbar ));
                list.Add("buttonAlign", new ConfigOption("buttonAlign", new SerializationOptions(JsonMode.ToLower), Alignment.Left, this.ButtonAlign ));
                list.Add("listeners", new ConfigOption("listeners", new SerializationOptions("listeners", JsonMode.Object), null, this.Listeners ));
                list.Add("directEvents", new ConfigOption("directEvents", new SerializationOptions("directEvents", JsonMode.Object), null, this.DirectEvents ));

                return list;
            }
        }
    }
}