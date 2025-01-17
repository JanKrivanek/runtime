// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace System.Runtime.Intrinsics.X86
{
    /// <summary>This class provides access to X86 AVX512BW hardware instructions via intrinsics</summary>
    [CLSCompliant(false)]
    public abstract class Avx512BW : Avx512F
    {
        internal Avx512BW() { }

        public static new bool IsSupported { [Intrinsic] get { return false; } }

        public new abstract class VL : Avx512F.VL
        {
            internal VL() { }

            public static new bool IsSupported { [Intrinsic] get { return false; } }
        }

        public new abstract class X64 : Avx512F.X64
        {
            internal X64() { }

            public static new bool IsSupported { [Intrinsic] get { return false; } }
        }

        /// <summary>
        /// __m512i _mm512_abs_epi8 (__m512i a)
        ///   VPABSB zmm1 {k1}{z}, zmm2/m512
        /// </summary>
        public static Vector512<byte> Abs(Vector512<sbyte> value) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_abs_epi16 (__m512i a)
        ///   VPABSW zmm1 {k1}{z}, zmm2/m512
        /// </summary>
        public static Vector512<ushort> Abs(Vector512<short> value) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_add_epi8 (__m512i a, __m512i b)
        ///   VPADDB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<sbyte> Add(Vector512<sbyte> left, Vector512<sbyte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_add_epi8 (__m512i a, __m512i b)
        ///   VPADDB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<byte> Add(Vector512<byte> left, Vector512<byte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_add_epi16 (__m512i a, __m512i b)
        ///   VPADDW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<short> Add(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_add_epi16 (__m512i a, __m512i b)
        ///   VPADDW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<ushort> Add(Vector512<ushort> left, Vector512<ushort> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_adds_epi8 (__m512i a, __m512i b)
        ///   VPADDSB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<sbyte> AddSaturate(Vector512<sbyte> left, Vector512<sbyte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_adds_epu8 (__m512i a, __m512i b)
        ///   VPADDUSB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<byte> AddSaturate(Vector512<byte> left, Vector512<byte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_adds_epi16 (__m512i a, __m512i b)
        ///   VPADDSW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<short> AddSaturate(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_adds_epu16 (__m512i a, __m512i b)
        ///   VPADDUSW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<ushort> AddSaturate(Vector512<ushort> left, Vector512<ushort> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_alignr_epi8 (__m512i a, __m512i b, const int count)
        ///   VPALIGNR zmm1 {k1}{z}, zmm2, zmm3/m512, imm8
        /// </summary>
        public static Vector512<sbyte> AlignRight(Vector512<sbyte> left, Vector512<sbyte> right, [ConstantExpected] byte mask) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_alignr_epi8 (__m512i a, __m512i b, const int count)
        ///   VPALIGNR zmm1 {k1}{z}, zmm2, zmm3/m512, imm8
        /// </summary>
        public static Vector512<byte> AlignRight(Vector512<byte> left, Vector512<byte> right, [ConstantExpected] byte mask) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_avg_epu8 (__m512i a, __m512i b)
        ///   VPAVGB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<byte> Average(Vector512<byte> left, Vector512<byte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_avg_epu16 (__m512i a, __m512i b)
        ///   VPAVGW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<ushort> Average(Vector512<ushort> left, Vector512<ushort> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_cvtepi8_epi16 (__m128i a)
        ///   VPMOVSXBW zmm1 {k1}{z}, ymm2/m256
        /// </summary>
        public static Vector512<short> ConvertToVector512Int16(Vector256<sbyte> value) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_cvtepu8_epi16 (__m128i a)
        ///   VPMOVZXBW zmm1 {k1}{z}, ymm2/m256
        /// </summary>
        public static Vector512<short> ConvertToVector512Int16(Vector256<byte> value) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_cvtepi8_epi16 (__m128i a)
        ///   VPMOVSXBW zmm1 {k1}{z}, ymm2/m256
        /// </summary>
        public static Vector512<ushort> ConvertToVector512UInt16(Vector256<sbyte> value) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_cvtepu8_epi16 (__m128i a)
        ///   VPMOVZXBW zmm1 {k1}{z}, ymm2/m256
        /// </summary>
        public static Vector512<ushort> ConvertToVector512UInt16(Vector256<byte> value) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_loadu_epi8 (__m512i const * mem_addr)
        ///   VMOVDQU8 zmm1 {k1}{z}, m512
        /// </summary>
        public static new unsafe Vector512<sbyte> LoadVector512(sbyte* address) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_loadu_epi8 (__m512i const * mem_addr)
        ///   VMOVDQU8 zmm1 {k1}{z}, m512
        /// </summary>
        public static new unsafe Vector512<byte> LoadVector512(byte* address) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_loadu_epi16 (__m512i const * mem_addr)
        ///   VMOVDQU16 zmm1 {k1}{z}, m512
        /// </summary>
        public static new unsafe Vector512<short> LoadVector512(short* address) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_loadu_epi16 (__m512i const * mem_addr)
        ///   VMOVDQU16 zmm1 {k1}{z}, m512
        /// </summary>
        public static new unsafe Vector512<ushort> LoadVector512(ushort* address) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_max_epi8 (__m512i a, __m512i b)
        ///   VPMAXSB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<sbyte> Max(Vector512<sbyte> left, Vector512<sbyte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_max_epu8 (__m512i a, __m512i b)
        ///   VPMAXUB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<byte> Max(Vector512<byte> left, Vector512<byte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_max_epi16 (__m512i a, __m512i b)
        ///   VPMAXSW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<short> Max(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_max_epu16 (__m512i a, __m512i b)
        ///   VPMAXUW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<ushort> Max(Vector512<ushort> left, Vector512<ushort> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_min_epi8 (__m512i a, __m512i b)
        ///   VPMINSB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<sbyte> Min(Vector512<sbyte> left, Vector512<sbyte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_min_epu8 (__m512i a, __m512i b)
        ///   VPMINUB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<byte> Min(Vector512<byte> left, Vector512<byte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_min_epi16 (__m512i a, __m512i b)
        ///   VPMINSW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<short> Min(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_min_epu16 (__m512i a, __m512i b)
        ///   VPMINUW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<ushort> Min(Vector512<ushort> left, Vector512<ushort> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_madd_epi16 (__m512i a, __m512i b)
        ///   VPMADDWD zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<int> MultiplyAddAdjacent(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_maddubs_epi16 (__m512i a, __m512i b)
        ///   VPMADDUBSW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<short> MultiplyAddAdjacent(Vector512<byte> left, Vector512<sbyte> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_mulhi_epi16 (__m512i a, __m512i b)
        ///   VPMULHW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<short> MultiplyHigh(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_mulhi_epu16 (__m512i a, __m512i b)
        ///   VPMULHUW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<ushort> MultiplyHigh(Vector512<ushort> left, Vector512<ushort> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_mulhrs_epi16 (__m512i a, __m512i b)
        ///   VPMULHRSW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<short> MultiplyHighRoundScale(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_mullo_epi16 (__m512i a, __m512i b)
        ///   VPMULLW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<short> MultiplyLow(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_mullo_epi16 (__m512i a, __m512i b)
        ///   VPMULLW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<ushort> MultiplyLow(Vector512<ushort> left, Vector512<ushort> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_packs_epi16 (__m512i a, __m512i b)
        ///   VPACKSSWB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<sbyte> PackSignedSaturate(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_packs_epi32 (__m512i a, __m512i b)
        ///   VPACKSSDW zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        /// </summary>
        public static Vector512<short> PackSignedSaturate(Vector512<int> left, Vector512<int> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_packus_epi16 (__m512i a, __m512i b)
        ///   VPACKUSWB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<byte> PackUnsignedSaturate(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_packus_epi32 (__m512i a, __m512i b)
        ///   VPACKUSDW zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        /// </summary>
        public static Vector512<ushort> PackUnsignedSaturate(Vector512<int> left, Vector512<int> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_sll_epi16 (__m512i a, __m128i count)
        ///   VPSLLW zmm1 {k1}{z}, zmm2, xmm3/m128
        /// </summary>
        public static Vector512<short> ShiftLeftLogical(Vector512<short> value, Vector128<short> count) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_sll_epi16 (__m512i a, __m128i count)
        ///   VPSLLW zmm1 {k1}{z}, zmm2, xmm3/m128
        /// </summary>
        public static Vector512<ushort> ShiftLeftLogical(Vector512<ushort> value, Vector128<ushort> count) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_slli_epi16 (__m512i a, int imm8)
        ///   VPSLLW zmm1 {k1}{z}, zmm2, imm8
        /// </summary>
        public static Vector512<short> ShiftLeftLogical(Vector512<short> value, [ConstantExpected] byte count) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_slli_epi16 (__m512i a, int imm8)
        ///   VPSLLW zmm1 {k1}{z}, zmm2, imm8
        /// </summary>
        public static Vector512<ushort> ShiftLeftLogical(Vector512<ushort> value, [ConstantExpected] byte count) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_bslli_epi128 (__m512i a, const int imm8)
        ///   VPSLLDQ zmm1, zmm2/m512, imm8
        /// </summary>
        public static Vector512<sbyte> ShiftLeftLogical128BitLane(Vector512<sbyte> value, [ConstantExpected] byte numBytes) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_bslli_epi128 (__m512i a, const int imm8)
        ///   VPSLLDQ zmm1, zmm2/m512, imm8
        /// </summary>
        public static Vector512<byte> ShiftLeftLogical128BitLane(Vector512<byte> value, [ConstantExpected] byte numBytes) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// _mm512_sra_epi16 (__m512i a, __m128i count)
        ///   VPSRAW zmm1 {k1}{z}, zmm2, xmm3/m128
        /// </summary>
        public static Vector512<short> ShiftRightArithmetic(Vector512<short> value, Vector128<short> count) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_srai_epi16 (__m512i a, int imm8)
        ///   VPSRAW zmm1 {k1}{z}, zmm2, imm8
        /// </summary>
        public static Vector512<short> ShiftRightArithmetic(Vector512<short> value, [ConstantExpected] byte count) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_srl_epi16 (__m512i a, __m128i count)
        ///   VPSRLW zmm1 {k1}{z}, zmm2, xmm3/m128
        /// </summary>
        public static Vector512<short> ShiftRightLogical(Vector512<short> value, Vector128<short> count) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_srl_epi16 (__m512i a, __m128i count)
        ///   VPSRLW zmm1 {k1}{z}, zmm2, xmm3/m128
        /// </summary>
        public static Vector512<ushort> ShiftRightLogical(Vector512<ushort> value, Vector128<ushort> count) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_srli_epi16 (__m512i a, int imm8)
        ///   VPSRLW zmm1 {k1}{z}, zmm2, imm8
        /// </summary>
        public static Vector512<short> ShiftRightLogical(Vector512<short> value, [ConstantExpected] byte count) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_srli_epi16 (__m512i a, int imm8)
        ///   VPSRLW zmm1 {k1}{z}, zmm2, imm8
        /// </summary>
        public static Vector512<ushort> ShiftRightLogical(Vector512<ushort> value, [ConstantExpected] byte count) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_bsrli_epi128 (__m512i a, const int imm8)
        ///   VPSRLDQ zmm1, zmm2/m128, imm8
        /// </summary>
        public static Vector512<sbyte> ShiftRightLogical128BitLane(Vector512<sbyte> value, [ConstantExpected] byte numBytes) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_bsrli_epi128 (__m512i a, const int imm8)
        ///   VPSRLDQ zmm1, zmm2/m128, imm8
        /// </summary>
        public static Vector512<byte> ShiftRightLogical128BitLane(Vector512<byte> value, [ConstantExpected] byte numBytes) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_shuffle_epi8 (__m512i a, __m512i b)
        ///   VPSHUFB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<sbyte> Shuffle(Vector512<sbyte> value, Vector512<sbyte> mask) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_shuffle_epi8 (__m512i a, __m512i b)
        ///   VPSHUFB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<byte> Shuffle(Vector512<byte> value, Vector512<byte> mask) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_shufflehi_epi16 (__m512i a, const int imm8)
        ///   VPSHUFHW zmm1 {k1}{z}, zmm2/m512, imm8
        /// </summary>
        public static Vector512<short> ShuffleHigh(Vector512<short> value, [ConstantExpected] byte control) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_shufflehi_epi16 (__m512i a, const int imm8)
        ///   VPSHUFHW zmm1 {k1}{z}, zmm2/m512, imm8
        /// </summary>
        public static Vector512<ushort> ShuffleHigh(Vector512<ushort> value, [ConstantExpected] byte control) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_shufflelo_epi16 (__m512i a, const int imm8)
        ///   VPSHUFLW zmm1 {k1}{z}, zmm2/m512, imm8
        /// </summary>
        public static Vector512<short> ShuffleLow(Vector512<short> value, [ConstantExpected] byte control) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_shufflelo_epi16 (__m512i a, const int imm8)
        ///   VPSHUFLW zmm1 {k1}{z}, zmm2/m512, imm8
        /// </summary>
        public static Vector512<ushort> ShuffleLow(Vector512<ushort> value, [ConstantExpected] byte control) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// void _mm512_storeu_epi8 (__m512i * mem_addr, __m512i a)
        ///   VMOVDQU8 m512 {k1}{z}, zmm1
        /// </summary>
        public static new unsafe void Store(sbyte* address, Vector512<sbyte> source) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// void _mm512_storeu_epi8 (__m512i * mem_addr, __m512i a)
        ///   VMOVDQU8 m512 {k1}{z}, zmm1
        /// </summary>
        public static new unsafe void Store(byte* address, Vector512<byte> source) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// void _mm512_storeu_epi16 (__m512i * mem_addr, __m512i a)
        ///   VMOVDQU16 m512 {k1}{z}, zmm1
        /// </summary>
        public static new unsafe void Store(short* address, Vector512<short> source) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// void _mm512_storeu_epi16 (__m512i * mem_addr, __m512i a)
        ///   VMOVDQU16 m512 {k1}{z}, zmm1
        /// </summary>
        public static new unsafe void Store(ushort* address, Vector512<ushort> source) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_sub_epi8 (__m512i a, __m512i b)
        ///   VPSUBB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<sbyte> Subtract(Vector512<sbyte> left, Vector512<sbyte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_sub_epi8 (__m512i a, __m512i b)
        ///   VPSUBB zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<byte> Subtract(Vector512<byte> left, Vector512<byte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_sub_epi16 (__m512i a, __m512i b)
        ///   VPSUBW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<short> Subtract(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_sub_epi16 (__m512i a, __m512i b)
        ///   VPSUBW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<ushort> Subtract(Vector512<ushort> left, Vector512<ushort> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_subs_epi8 (__m512i a, __m512i b)
        ///   VPSUBSB zmm1 {k1}{z}, zmm2, zmm3/m128
        /// </summary>
        public static Vector512<sbyte> SubtractSaturate(Vector512<sbyte> left, Vector512<sbyte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_subs_epi16 (__m512i a, __m512i b)
        ///   VPSUBSW zmm1 {k1}{z}, zmm2, zmm3/m128
        /// </summary>
        public static Vector512<short> SubtractSaturate(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_subs_epu8 (__m512i a, __m512i b)
        ///   VPSUBUSB zmm1 {k1}{z}, zmm2, zmm3/m128
        /// </summary>
        public static Vector512<byte> SubtractSaturate(Vector512<byte> left, Vector512<byte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_subs_epu16 (__m512i a, __m512i b)
        ///   VPSUBUSW zmm1 {k1}{z}, zmm2, zmm3/m128
        /// </summary>
        public static Vector512<ushort> SubtractSaturate(Vector512<ushort> left, Vector512<ushort> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_sad_epu8 (__m512i a, __m512i b)
        ///   VPSADBW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<ushort> SumAbsoluteDifferences(Vector512<byte> left, Vector512<byte> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_unpackhi_epi8 (__m512i a, __m512i b)
        ///   VPUNPCKHBW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<sbyte> UnpackHigh(Vector512<sbyte> left, Vector512<sbyte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_unpackhi_epi8 (__m512i a, __m512i b)
        ///   VPUNPCKHBW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<byte> UnpackHigh(Vector512<byte> left, Vector512<byte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_unpackhi_epi16 (__m512i a, __m512i b)
        ///   VPUNPCKHWD zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<short> UnpackHigh(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_unpackhi_epi16 (__m512i a, __m512i b)
        ///   VPUNPCKHWD zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<ushort> UnpackHigh(Vector512<ushort> left, Vector512<ushort> right) { throw new PlatformNotSupportedException(); }

        /// <summary>
        /// __m512i _mm512_unpacklo_epi8 (__m512i a, __m512i b)
        ///   VPUNPCKLBW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<sbyte> UnpackLow(Vector512<sbyte> left, Vector512<sbyte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_unpacklo_epi8 (__m512i a, __m512i b)
        ///   VPUNPCKLBW zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<byte> UnpackLow(Vector512<byte> left, Vector512<byte> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_unpacklo_epi16 (__m512i a, __m512i b)
        ///   VPUNPCKLWD zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<short> UnpackLow(Vector512<short> left, Vector512<short> right) { throw new PlatformNotSupportedException(); }
        /// <summary>
        /// __m512i _mm512_unpacklo_epi16 (__m512i a, __m512i b)
        ///   VPUNPCKLWD zmm1 {k1}{z}, zmm2, zmm3/m512
        /// </summary>
        public static Vector512<ushort> UnpackLow(Vector512<ushort> left, Vector512<ushort> right) { throw new PlatformNotSupportedException(); }
    }
}
