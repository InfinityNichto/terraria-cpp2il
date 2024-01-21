using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.Graphics.Light;

[Cpp2IlInjected.Token(Token = "0x2000512")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x3851C8", Offset = "0x3851C8")]
public class LightMap
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006827")]
	public Vector3[] _colors;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006828")]
	public LightMaskMode[] _mask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006829")]
	private Vector3[] _decayColors;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400682A")]
	private FastRandom _random;

	[Cpp2IlInjected.Token(Token = "0x400682B")]
	private const int DEFAULT_WIDTH = 203;

	[Cpp2IlInjected.Token(Token = "0x400682C")]
	private const int DEFAULT_HEIGHT = 203;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400682D")]
	private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400682E")]
	private ThreadedRenderManager _threadManager;

	[Cpp2IlInjected.Token(Token = "0x170006FF")]
	public int NonVisiblePadding
	{
		[Cpp2IlInjected.Token(Token = "0x600382F")]
		[Cpp2IlInjected.Address(RVA = "0x1510E68", Offset = "0x1510E68", VA = "0x1510E68")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003830")]
		[Cpp2IlInjected.Address(RVA = "0x1510E70", Offset = "0x1510E70", VA = "0x1510E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000700")]
	public int Width
	{
		[Cpp2IlInjected.Token(Token = "0x6003831")]
		[Cpp2IlInjected.Address(RVA = "0x1510E78", Offset = "0x1510E78", VA = "0x1510E78")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003832")]
		[Cpp2IlInjected.Address(RVA = "0x1510E80", Offset = "0x1510E80", VA = "0x1510E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000701")]
	public int Height
	{
		[Cpp2IlInjected.Token(Token = "0x6003833")]
		[Cpp2IlInjected.Address(RVA = "0x1510E88", Offset = "0x1510E88", VA = "0x1510E88")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003834")]
		[Cpp2IlInjected.Address(RVA = "0x1510E90", Offset = "0x1510E90", VA = "0x1510E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000702")]
	public float LightDecayThroughAir
	{
		[Cpp2IlInjected.Token(Token = "0x6003835")]
		[Cpp2IlInjected.Address(RVA = "0x1510B80", Offset = "0x1510B80", VA = "0x1510B80")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6003836")]
		[Cpp2IlInjected.Address(RVA = "0x1510AE8", Offset = "0x1510AE8", VA = "0x1510AE8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000703")]
	public float LightDecayThroughSolid
	{
		[Cpp2IlInjected.Token(Token = "0x6003837")]
		[Cpp2IlInjected.Address(RVA = "0x1510B8C", Offset = "0x1510B8C", VA = "0x1510B8C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6003838")]
		[Cpp2IlInjected.Address(RVA = "0x1510B34", Offset = "0x1510B34", VA = "0x1510B34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000704")]
	public Vector3 LightDecayThroughWater
	{
		[Cpp2IlInjected.Token(Token = "0x6003839")]
		[Cpp2IlInjected.Address(RVA = "0x1510BA8", Offset = "0x1510BA8", VA = "0x1510BA8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600383A")]
		[Cpp2IlInjected.Address(RVA = "0x1510B98", Offset = "0x1510B98", VA = "0x1510B98")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000705")]
	public Vector3 LightDecayThroughHoney
	{
		[Cpp2IlInjected.Token(Token = "0x600383B")]
		[Cpp2IlInjected.Address(RVA = "0x1510E98", Offset = "0x1510E98", VA = "0x1510E98")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600383C")]
		[Cpp2IlInjected.Address(RVA = "0x1510BC0", Offset = "0x1510BC0", VA = "0x1510BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000706")]
	public Vector3 Item
	{
		[Cpp2IlInjected.Token(Token = "0x600383D")]
		[Cpp2IlInjected.Address(RVA = "0x150E044", Offset = "0x150E044", VA = "0x150E044")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600383E")]
		[Cpp2IlInjected.Address(RVA = "0x1510EBC", Offset = "0x1510EBC", VA = "0x1510EBC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000707")]
	private ThreadedRenderManager.BatchProcessCallback ExportBatchFinishedCallback
	{
		[Cpp2IlInjected.Token(Token = "0x6003848")]
		[Cpp2IlInjected.Address(RVA = "0x15110A8", Offset = "0x15110A8", VA = "0x15110A8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600383F")]
	[Cpp2IlInjected.Address(RVA = "0x150DBF8", Offset = "0x150DBF8", VA = "0x150DBF8")]
	public LightMap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003840")]
	[Cpp2IlInjected.Address(RVA = "0x1510EF0", Offset = "0x1510EF0", VA = "0x1510EF0")]
	public void GetLight(int x, int y, out Vector3 color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003841")]
	[Cpp2IlInjected.Address(RVA = "0x1510F20", Offset = "0x1510F20", VA = "0x1510F20")]
	public LightMaskMode GetMask(int x, int y)
	{
		return default(LightMaskMode);
	}

	[Cpp2IlInjected.Token(Token = "0x6003842")]
	[Cpp2IlInjected.Address(RVA = "0x15104EC", Offset = "0x15104EC", VA = "0x15104EC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394DC4", Offset = "0x394DC4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394DC4", Offset = "0x394DC4")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003843")]
	[Cpp2IlInjected.Address(RVA = "0x1510F38", Offset = "0x1510F38", VA = "0x1510F38")]
	public void SetMaskAt(int x, int y, LightMaskMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003844")]
	[Cpp2IlInjected.Address(RVA = "0x1510F50", Offset = "0x1510F50", VA = "0x1510F50")]
	public void BlurPass1()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003845")]
	[Cpp2IlInjected.Address(RVA = "0x151105C", Offset = "0x151105C", VA = "0x151105C")]
	public void BlurPass2()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003846")]
	[Cpp2IlInjected.Address(RVA = "0x151107C", Offset = "0x151107C", VA = "0x151107C")]
	public void Blur()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003847")]
	[Cpp2IlInjected.Address(RVA = "0x15110A4", Offset = "0x15110A4", VA = "0x15110A4")]
	private void ExportBatchFinished(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003849")]
	[Cpp2IlInjected.Address(RVA = "0x1511138", Offset = "0x1511138", VA = "0x1511138")]
	private void Blur1PassThreaded(int start, int end)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600384A")]
	[Cpp2IlInjected.Address(RVA = "0x151129C", Offset = "0x151129C", VA = "0x151129C")]
	public unsafe static extern void Blur1PassNative(Vector3* colors, Vector3* decayData, LightMaskMode* maskData, int start, int end, int width, int height);

	[Cpp2IlInjected.Token(Token = "0x600384B")]
	[Cpp2IlInjected.Address(RVA = "0x15112A0", Offset = "0x15112A0", VA = "0x15112A0")]
	public unsafe static extern void Blur2PassNative(Vector3* colors, Vector3* decayData, LightMaskMode* maskData, int start, int end, int width, int height);

	[Cpp2IlInjected.Token(Token = "0x600384C")]
	[Cpp2IlInjected.Address(RVA = "0x1511210", Offset = "0x1511210", VA = "0x1511210")]
	public void Blur1Pass(int start, int end)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600384D")]
	[Cpp2IlInjected.Address(RVA = "0x15112A4", Offset = "0x15112A4", VA = "0x15112A4")]
	private void Blur2PassThreaded(int start, int end)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600384E")]
	[Cpp2IlInjected.Address(RVA = "0x151137C", Offset = "0x151137C", VA = "0x151137C")]
	public void Blur2Pass(int start, int end)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600384F")]
	[Cpp2IlInjected.Address(RVA = "0x1510F54", Offset = "0x1510F54", VA = "0x1510F54")]
	private void BlurPass()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003850")]
	[Cpp2IlInjected.Address(RVA = "0x1510BD0", Offset = "0x1510BD0", VA = "0x1510BD0")]
	public void ExecutePartialBlur(int pass)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003851")]
	[Cpp2IlInjected.Address(RVA = "0x15115DC", Offset = "0x15115DC", VA = "0x15115DC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394E78", Offset = "0x394E78")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394E78", Offset = "0x394E78")]
	private void BlurLine(int startIndex, int endIndex, int stride)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003852")]
	[Cpp2IlInjected.Address(RVA = "0x1511408", Offset = "0x1511408", VA = "0x1511408")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394F2C", Offset = "0x394F2C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394F2C", Offset = "0x394F2C")]
	private void BlurLine2(int startIndex, int endIndex, int stride)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003853")]
	[Cpp2IlInjected.Address(RVA = "0x1510EB0", Offset = "0x1510EB0", VA = "0x1510EB0")]
	private int IndexOf(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003854")]
	[Cpp2IlInjected.Address(RVA = "0x150E1A0", Offset = "0x150E1A0", VA = "0x150E1A0")]
	public void SetSize(int width, int height)
	{
	}
}
