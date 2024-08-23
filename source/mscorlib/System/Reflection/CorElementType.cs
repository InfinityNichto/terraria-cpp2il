using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	// Token: 0x0200043D RID: 1085
	[global::Cpp2ILInjected.Token(Token = "0x20004FC")]
	[global::System.Serializable]
	internal enum CorElementType : byte
	{
		// Token: 0x0400112D RID: 4397
		[global::Cpp2ILInjected.Token(Token = "0x4001447")]
		End,
		// Token: 0x0400112E RID: 4398
		[global::Cpp2ILInjected.Token(Token = "0x4001448")]
		Void,
		// Token: 0x0400112F RID: 4399
		[global::Cpp2ILInjected.Token(Token = "0x4001449")]
		Boolean,
		// Token: 0x04001130 RID: 4400
		[global::Cpp2ILInjected.Token(Token = "0x400144A")]
		Char,
		// Token: 0x04001131 RID: 4401
		[global::Cpp2ILInjected.Token(Token = "0x400144B")]
		I1,
		// Token: 0x04001132 RID: 4402
		[global::Cpp2ILInjected.Token(Token = "0x400144C")]
		U1,
		// Token: 0x04001133 RID: 4403
		[global::Cpp2ILInjected.Token(Token = "0x400144D")]
		I2,
		// Token: 0x04001134 RID: 4404
		[global::Cpp2ILInjected.Token(Token = "0x400144E")]
		U2,
		// Token: 0x04001135 RID: 4405
		[global::Cpp2ILInjected.Token(Token = "0x400144F")]
		I4,
		// Token: 0x04001136 RID: 4406
		[global::Cpp2ILInjected.Token(Token = "0x4001450")]
		U4,
		// Token: 0x04001137 RID: 4407
		[global::Cpp2ILInjected.Token(Token = "0x4001451")]
		I8,
		// Token: 0x04001138 RID: 4408
		[global::Cpp2ILInjected.Token(Token = "0x4001452")]
		U8,
		// Token: 0x04001139 RID: 4409
		[global::Cpp2ILInjected.Token(Token = "0x4001453")]
		R4,
		// Token: 0x0400113A RID: 4410
		[global::Cpp2ILInjected.Token(Token = "0x4001454")]
		R8,
		// Token: 0x0400113B RID: 4411
		[global::Cpp2ILInjected.Token(Token = "0x4001455")]
		String,
		// Token: 0x0400113C RID: 4412
		[global::Cpp2ILInjected.Token(Token = "0x4001456")]
		Ptr,
		// Token: 0x0400113D RID: 4413
		[global::Cpp2ILInjected.Token(Token = "0x4001457")]
		ByRef,
		// Token: 0x0400113E RID: 4414
		[global::Cpp2ILInjected.Token(Token = "0x4001458")]
		ValueType,
		// Token: 0x0400113F RID: 4415
		[global::Cpp2ILInjected.Token(Token = "0x4001459")]
		Class,
		// Token: 0x04001140 RID: 4416
		[global::Cpp2ILInjected.Token(Token = "0x400145A")]
		Var,
		// Token: 0x04001141 RID: 4417
		[global::Cpp2ILInjected.Token(Token = "0x400145B")]
		Array,
		// Token: 0x04001142 RID: 4418
		[global::Cpp2ILInjected.Token(Token = "0x400145C")]
		GenericInst,
		// Token: 0x04001143 RID: 4419
		[global::Cpp2ILInjected.Token(Token = "0x400145D")]
		TypedByRef,
		// Token: 0x04001144 RID: 4420
		[global::Cpp2ILInjected.Token(Token = "0x400145E")]
		I = 24,
		// Token: 0x04001145 RID: 4421
		[global::Cpp2ILInjected.Token(Token = "0x400145F")]
		U,
		// Token: 0x04001146 RID: 4422
		[global::Cpp2ILInjected.Token(Token = "0x4001460")]
		FnPtr = 27,
		// Token: 0x04001147 RID: 4423
		[global::Cpp2ILInjected.Token(Token = "0x4001461")]
		Object,
		// Token: 0x04001148 RID: 4424
		[global::Cpp2ILInjected.Token(Token = "0x4001462")]
		SzArray,
		// Token: 0x04001149 RID: 4425
		[global::Cpp2ILInjected.Token(Token = "0x4001463")]
		MVar,
		// Token: 0x0400114A RID: 4426
		[global::Cpp2ILInjected.Token(Token = "0x4001464")]
		CModReqd,
		// Token: 0x0400114B RID: 4427
		[global::Cpp2ILInjected.Token(Token = "0x4001465")]
		CModOpt,
		// Token: 0x0400114C RID: 4428
		[global::Cpp2ILInjected.Token(Token = "0x4001466")]
		Internal,
		// Token: 0x0400114D RID: 4429
		[global::Cpp2ILInjected.Token(Token = "0x4001467")]
		Max,
		// Token: 0x0400114E RID: 4430
		[global::Cpp2ILInjected.Token(Token = "0x4001468")]
		Modifier = 64,
		// Token: 0x0400114F RID: 4431
		[global::Cpp2ILInjected.Token(Token = "0x4001469")]
		Sentinel,
		// Token: 0x04001150 RID: 4432
		[global::Cpp2ILInjected.Token(Token = "0x400146A")]
		Pinned = 69,
		// Token: 0x04001151 RID: 4433
		[global::Cpp2ILInjected.Token(Token = "0x400146B")]
		ELEMENT_TYPE_END = 0,
		// Token: 0x04001152 RID: 4434
		[global::Cpp2ILInjected.Token(Token = "0x400146C")]
		ELEMENT_TYPE_VOID,
		// Token: 0x04001153 RID: 4435
		[global::Cpp2ILInjected.Token(Token = "0x400146D")]
		ELEMENT_TYPE_BOOLEAN,
		// Token: 0x04001154 RID: 4436
		[global::Cpp2ILInjected.Token(Token = "0x400146E")]
		ELEMENT_TYPE_CHAR,
		// Token: 0x04001155 RID: 4437
		[global::Cpp2ILInjected.Token(Token = "0x400146F")]
		ELEMENT_TYPE_I1,
		// Token: 0x04001156 RID: 4438
		[global::Cpp2ILInjected.Token(Token = "0x4001470")]
		ELEMENT_TYPE_U1,
		// Token: 0x04001157 RID: 4439
		[global::Cpp2ILInjected.Token(Token = "0x4001471")]
		ELEMENT_TYPE_I2,
		// Token: 0x04001158 RID: 4440
		[global::Cpp2ILInjected.Token(Token = "0x4001472")]
		ELEMENT_TYPE_U2,
		// Token: 0x04001159 RID: 4441
		[global::Cpp2ILInjected.Token(Token = "0x4001473")]
		ELEMENT_TYPE_I4,
		// Token: 0x0400115A RID: 4442
		[global::Cpp2ILInjected.Token(Token = "0x4001474")]
		ELEMENT_TYPE_U4,
		// Token: 0x0400115B RID: 4443
		[global::Cpp2ILInjected.Token(Token = "0x4001475")]
		ELEMENT_TYPE_I8,
		// Token: 0x0400115C RID: 4444
		[global::Cpp2ILInjected.Token(Token = "0x4001476")]
		ELEMENT_TYPE_U8,
		// Token: 0x0400115D RID: 4445
		[global::Cpp2ILInjected.Token(Token = "0x4001477")]
		ELEMENT_TYPE_R4,
		// Token: 0x0400115E RID: 4446
		[global::Cpp2ILInjected.Token(Token = "0x4001478")]
		ELEMENT_TYPE_R8,
		// Token: 0x0400115F RID: 4447
		[global::Cpp2ILInjected.Token(Token = "0x4001479")]
		ELEMENT_TYPE_STRING,
		// Token: 0x04001160 RID: 4448
		[global::Cpp2ILInjected.Token(Token = "0x400147A")]
		ELEMENT_TYPE_PTR,
		// Token: 0x04001161 RID: 4449
		[global::Cpp2ILInjected.Token(Token = "0x400147B")]
		ELEMENT_TYPE_BYREF,
		// Token: 0x04001162 RID: 4450
		[global::Cpp2ILInjected.Token(Token = "0x400147C")]
		ELEMENT_TYPE_VALUETYPE,
		// Token: 0x04001163 RID: 4451
		[global::Cpp2ILInjected.Token(Token = "0x400147D")]
		ELEMENT_TYPE_CLASS,
		// Token: 0x04001164 RID: 4452
		[global::Cpp2ILInjected.Token(Token = "0x400147E")]
		ELEMENT_TYPE_VAR,
		// Token: 0x04001165 RID: 4453
		[global::Cpp2ILInjected.Token(Token = "0x400147F")]
		ELEMENT_TYPE_ARRAY,
		// Token: 0x04001166 RID: 4454
		[global::Cpp2ILInjected.Token(Token = "0x4001480")]
		ELEMENT_TYPE_GENERICINST,
		// Token: 0x04001167 RID: 4455
		[global::Cpp2ILInjected.Token(Token = "0x4001481")]
		ELEMENT_TYPE_TYPEDBYREF,
		// Token: 0x04001168 RID: 4456
		[global::Cpp2ILInjected.Token(Token = "0x4001482")]
		ELEMENT_TYPE_I = 24,
		// Token: 0x04001169 RID: 4457
		[global::Cpp2ILInjected.Token(Token = "0x4001483")]
		ELEMENT_TYPE_U,
		// Token: 0x0400116A RID: 4458
		[global::Cpp2ILInjected.Token(Token = "0x4001484")]
		ELEMENT_TYPE_FNPTR = 27,
		// Token: 0x0400116B RID: 4459
		[global::Cpp2ILInjected.Token(Token = "0x4001485")]
		ELEMENT_TYPE_OBJECT,
		// Token: 0x0400116C RID: 4460
		[global::Cpp2ILInjected.Token(Token = "0x4001486")]
		ELEMENT_TYPE_SZARRAY,
		// Token: 0x0400116D RID: 4461
		[global::Cpp2ILInjected.Token(Token = "0x4001487")]
		ELEMENT_TYPE_MVAR,
		// Token: 0x0400116E RID: 4462
		[global::Cpp2ILInjected.Token(Token = "0x4001488")]
		ELEMENT_TYPE_CMOD_REQD,
		// Token: 0x0400116F RID: 4463
		[global::Cpp2ILInjected.Token(Token = "0x4001489")]
		ELEMENT_TYPE_CMOD_OPT,
		// Token: 0x04001170 RID: 4464
		[global::Cpp2ILInjected.Token(Token = "0x400148A")]
		ELEMENT_TYPE_INTERNAL,
		// Token: 0x04001171 RID: 4465
		[global::Cpp2ILInjected.Token(Token = "0x400148B")]
		ELEMENT_TYPE_MAX,
		// Token: 0x04001172 RID: 4466
		[global::Cpp2ILInjected.Token(Token = "0x400148C")]
		ELEMENT_TYPE_MODIFIER = 64,
		// Token: 0x04001173 RID: 4467
		[global::Cpp2ILInjected.Token(Token = "0x400148D")]
		ELEMENT_TYPE_SENTINEL,
		// Token: 0x04001174 RID: 4468
		[global::Cpp2ILInjected.Token(Token = "0x400148E")]
		ELEMENT_TYPE_PINNED = 69
	}
}
