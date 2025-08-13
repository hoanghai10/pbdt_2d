using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TBA2D.Properties
{
	// Token: 0x02000047 RID: 71
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal class Resources
	{
		// Token: 0x060002F0 RID: 752 RVA: 0x000C9BD3 File Offset: 0x000C7DD3
		internal Resources()
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x000C9BE0 File Offset: 0x000C7DE0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("TBA2D.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x000C9C2C File Offset: 0x000C7E2C
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x000C9C43 File Offset: 0x000C7E43
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x000C9C4C File Offset: 0x000C7E4C
		internal static Bitmap LAN_Connected
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("LAN_Connected", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x000C9C7C File Offset: 0x000C7E7C
		internal static Bitmap LAN_Connected_
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("LAN_Connected_", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x000C9CAC File Offset: 0x000C7EAC
		internal static Bitmap LAN_Disconnected
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("LAN_Disconnected", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x000C9CDC File Offset: 0x000C7EDC
		internal static Bitmap LAN_Disconnected_
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("LAN_Disconnected_", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x0400103F RID: 4159
		private static ResourceManager resourceMan;

		// Token: 0x04001040 RID: 4160
		private static CultureInfo resourceCulture;
	}
}
