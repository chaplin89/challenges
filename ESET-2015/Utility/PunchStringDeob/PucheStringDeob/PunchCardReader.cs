using System.Text;

namespace PunchStringDeob
{
    class PunchCardReader
    {
        internal static string[] string_0 = new string[114];
        internal static byte[] byte_0 = new byte[1485]
        {
      (byte) 154,
      (byte) 155,
      (byte) 153,
      (byte) 153,
      (byte) 158,
      (byte) 159,
      (byte) 156,
      (byte) 157,
      (byte) 146,
      (byte) 147,
      (byte) 144,
      (byte) 145,
      (byte) 150,
      (byte) 151,
      (byte) 148,
      (byte) 148,
      (byte) 138,
      (byte) 139,
      (byte) 136,
      (byte) 137,
      (byte) 142,
      (byte) 143,
      (byte) 140,
      (byte) 141,
      (byte) 130,
      (byte) 131,
      unchecked((byte) sbyte.MinValue),
      (byte) 129,
      (byte) 135,
      (byte) 135,
      (byte) 132,
      (byte) 133,
      (byte) 186,
      (byte) 187,
      (byte) 184,
      (byte) 185,
      (byte) 190,
      (byte) 191,
      (byte) 188,
      (byte) 189,
      (byte) 178,
      (byte) 178,
      (byte) 176,
      (byte) 177,
      (byte) 182,
      (byte) 183,
      (byte) 180,
      (byte) 181,
      (byte) 170,
      (byte) 171,
      (byte) 168,
      (byte) 169,
      (byte) 174,
      (byte) 175,
      (byte) 173,
      (byte) 173,
      (byte) 162,
      (byte) 163,
      (byte) 160,
      (byte) 161,
      (byte) 166,
      (byte) 167,
      (byte) 164,
      (byte) 165,
      (byte) 218,
      (byte) 219,
      (byte) 216,
      (byte) 216,
      (byte) 222,
      (byte) 223,
      (byte) 220,
      (byte) 221,
      (byte) 210,
      (byte) 211,
      (byte) 208,
      (byte) 209,
      (byte) 214,
      (byte) 215,
      (byte) 212,
      (byte) 213,
      (byte) 203,
      (byte) 203,
      (byte) 200,
      (byte) 201,
      (byte) 206,
      (byte) 207,
      (byte) 204,
      (byte) 205,
      (byte) 194,
      (byte) 195,
      (byte) 192,
      (byte) 193,
      (byte) 198,
      (byte) 198,
      (byte) 196,
      (byte) 197,
      (byte) 250,
      (byte) 251,
      (byte) 248,
      (byte) 249,
      (byte) 254,
      byte.MaxValue,
      (byte) 252,
      (byte) 253,
      (byte) 242,
      (byte) 243,
      (byte) 241,
      (byte) 241,
      (byte) 246,
      (byte) 247,
      (byte) 244,
      (byte) 245,
      (byte) 234,
      (byte) 235,
      (byte) 232,
      (byte) 233,
      (byte) 238,
      (byte) 239,
      (byte) 236,
      (byte) 236,
      (byte) 227,
      (byte) 227,
      (byte) 224,
      (byte) 224,
      (byte) 230,
      (byte) 231,
      (byte) 228,
      (byte) 229,
      (byte) 26,
      (byte) 27,
      (byte) 24,
      (byte) 25,
      (byte) 31,
      (byte) 31,
      (byte) 28,
      (byte) 29,
      (byte) 19,
      (byte) 19,
      (byte) 16,
      (byte) 17,
      (byte) 22,
      (byte) 23,
      (byte) 20,
      (byte) 21,
      (byte) 11,
      (byte) 11,
      (byte) 8,
      (byte) 9,
      (byte) 14,
      (byte) 14,
      (byte) 12,
      (byte) 13,
      (byte) 2,
      (byte) 3,
      (byte) 0,
      (byte) 1,
      (byte) 7,
      (byte) 7,
      (byte) 4,
      (byte) 5,
      (byte) 58,
      (byte) 59,
      (byte) 57,
      (byte) 57,
      (byte) 62,
      (byte) 63,
      (byte) 60,
      (byte) 61,
      (byte) 51,
      (byte) 51,
      (byte) 48,
      (byte) 49,
      (byte) 54,
      (byte) 55,
      (byte) 52,
      (byte) 52,
      (byte) 42,
      (byte) 43,
      (byte) 40,
      (byte) 41,
      (byte) 47,
      (byte) 47,
      (byte) 44,
      (byte) 45,
      (byte) 34,
      (byte) 35,
      (byte) 32,
      (byte) 33,
      (byte) 39,
      (byte) 39,
      (byte) 36,
      (byte) 37,
      (byte) 91,
      (byte) 91,
      (byte) 88,
      (byte) 89,
      (byte) 94,
      (byte) 95,
      (byte) 92,
      (byte) 93,
      (byte) 82,
      (byte) 82,
      (byte) 80,
      (byte) 81,
      (byte) 87,
      (byte) 87,
      (byte) 84,
      (byte) 85,
      (byte) 74,
      (byte) 75,
      (byte) 72,
      (byte) 73,
      (byte) 78,
      (byte) 79,
      (byte) 77,
      (byte) 77,
      (byte) 67,
      (byte) 67,
      (byte) 64,
      (byte) 65,
      (byte) 70,
      (byte) 71,
      (byte) 68,
      (byte) 69,
      (byte) 122,
      (byte) 123,
      (byte) 120,
      (byte) 120,
      (byte) 126,
      (byte) 126,
      (byte) 124,
      (byte) 124,
      (byte) 114,
      (byte) 115,
      (byte) 112,
      (byte) 113,
      (byte) 118,
      (byte) 119,
      (byte) 116,
      (byte) 117,
      (byte) 106,
      (byte) 106,
      (byte) 104,
      (byte) 105,
      (byte) 111,
      (byte) 111,
      (byte) 108,
      (byte) 109,
      (byte) 98,
      (byte) 99,
      (byte) 96,
      (byte) 97,
      (byte) 102,
      (byte) 102,
      (byte) 100,
      (byte) 101,
      (byte) 154,
      (byte) 154,
      (byte) 152,
      (byte) 153,
      (byte) 158,
      (byte) 159,
      (byte) 156,
      (byte) 157,
      (byte) 146,
      (byte) 146,
      (byte) 144,
      (byte) 145,
      (byte) 150,
      (byte) 151,
      (byte) 149,
      (byte) 149,
      (byte) 138,
      (byte) 139,
      (byte) 136,
      (byte) 137,
      (byte) 142,
      (byte) 142,
      (byte) 140,
      (byte) 141,
      (byte) 130,
      (byte) 131,
      unchecked((byte) sbyte.MinValue),
      unchecked((byte) sbyte.MinValue),
      (byte) 134,
      (byte) 135,
      (byte) 132,
      (byte) 133,
      (byte) 186,
      (byte) 186,
      (byte) 184,
      (byte) 185,
      (byte) 190,
      (byte) 191,
      (byte) 188,
      (byte) 189,
      (byte) 179,
      (byte) 179,
      (byte) 176,
      (byte) 177,
      (byte) 182,
      (byte) 182,
      (byte) 180,
      (byte) 181,
      (byte) 170,
      (byte) 171,
      (byte) 168,
      (byte) 169,
      (byte) 174,
      (byte) 174,
      (byte) 172,
      (byte) 173,
      (byte) 162,
      (byte) 162,
      (byte) 160,
      (byte) 161,
      (byte) 166,
      (byte) 167,
      (byte) 164,
      (byte) 165,
      (byte) 218,
      (byte) 219,
      (byte) 217,
      (byte) 217,
      (byte) 222,
      (byte) 222,
      (byte) 220,
      (byte) 221,
      (byte) 210,
      (byte) 211,
      (byte) 208,
      (byte) 209,
      (byte) 214,
      (byte) 215,
      (byte) 212,
      (byte) 212,
      (byte) 202,
      (byte) 203,
      (byte) 201,
      (byte) 200,
      (byte) 206,
      (byte) 207,
      (byte) 204,
      (byte) 205,
      (byte) 194,
      (byte) 195,
      (byte) 192,
      (byte) 193,
      (byte) 198,
      (byte) 199,
      (byte) 197,
      (byte) 197,
      (byte) 251,
      (byte) 251,
      (byte) 248,
      (byte) 249,
      (byte) 254,
      byte.MaxValue,
      (byte) 252,
      (byte) 253,
      (byte) 242,
      (byte) 243,
      (byte) 241,
      (byte) 241,
      (byte) 246,
      (byte) 246,
      (byte) 244,
      (byte) 245,
      (byte) 234,
      (byte) 235,
      (byte) 232,
      (byte) 233,
      (byte) 238,
      (byte) 239,
      (byte) 237,
      (byte) 237,
      (byte) 226,
      (byte) 227,
      (byte) 225,
      (byte) 225,
      (byte) 230,
      (byte) 231,
      (byte) 228,
      (byte) 229,
      (byte) 26,
      (byte) 27,
      (byte) 25,
      (byte) 25,
      (byte) 30,
      (byte) 31,
      (byte) 28,
      (byte) 28,
      (byte) 18,
      (byte) 19,
      (byte) 16,
      (byte) 17,
      (byte) 22,
      (byte) 23,
      (byte) 21,
      (byte) 21,
      (byte) 10,
      (byte) 11,
      (byte) 8,
      (byte) 9,
      (byte) 15,
      (byte) 15,
      (byte) 12,
      (byte) 13,
      (byte) 2,
      (byte) 3,
      (byte) 1,
      (byte) 1,
      (byte) 6,
      (byte) 7,
      (byte) 4,
      (byte) 5,
      (byte) 58,
      (byte) 58,
      (byte) 56,
      (byte) 57,
      (byte) 62,
      (byte) 63,
      (byte) 61,
      (byte) 61,
      (byte) 50,
      (byte) 51,
      (byte) 48,
      (byte) 49,
      (byte) 54,
      (byte) 55,
      (byte) 53,
      (byte) 53,
      (byte) 42,
      (byte) 43,
      (byte) 41,
      (byte) 41,
      (byte) 46,
      (byte) 47,
      (byte) 44,
      (byte) 45,
      (byte) 34,
      (byte) 35,
      (byte) 32,
      (byte) 32,
      (byte) 39,
      (byte) 39,
      (byte) 37,
      (byte) 36,
      (byte) 90,
      (byte) 91,
      (byte) 88,
      (byte) 89,
      (byte) 94,
      (byte) 95,
      (byte) 92,
      (byte) 93,
      (byte) 83,
      (byte) 83,
      (byte) 81,
      (byte) 81,
      (byte) 87,
      (byte) 87,
      (byte) 84,
      (byte) 85,
      (byte) 74,
      (byte) 75,
      (byte) 72,
      (byte) 73,
      (byte) 79,
      (byte) 79,
      (byte) 77,
      (byte) 77,
      (byte) 66,
      (byte) 66,
      (byte) 64,
      (byte) 65,
      (byte) 70,
      (byte) 71,
      (byte) 68,
      (byte) 69,
      (byte) 123,
      (byte) 123,
      (byte) 121,
      (byte) 121,
      (byte) 126,
      (byte) 127,
      (byte) 125,
      (byte) 125,
      (byte) 114,
      (byte) 115,
      (byte) 112,
      (byte) 113,
      (byte) 119,
      (byte) 119,
      (byte) 117,
      (byte) 117,
      (byte) 106,
      (byte) 107,
      (byte) 104,
      (byte) 104,
      (byte) 110,
      (byte) 111,
      (byte) 108,
      (byte) 109,
      (byte) 99,
      (byte) 99,
      (byte) 97,
      (byte) 97,
      (byte) 102,
      (byte) 103,
      (byte) 100,
      (byte) 101,
      (byte) 155,
      (byte) 155,
      (byte) 152,
      (byte) 153,
      (byte) 159,
      (byte) 159,
      (byte) 157,
      (byte) 157,
      (byte) 146,
      (byte) 147,
      (byte) 144,
      (byte) 145,
      (byte) 150,
      (byte) 150,
      (byte) 148,
      (byte) 149,
      (byte) 139,
      (byte) 139,
      (byte) 137,
      (byte) 137,
      (byte) 142,
      (byte) 143,
      (byte) 140,
      (byte) 141,
      (byte) 130,
      (byte) 131,
      (byte) 129,
      (byte) 129,
      (byte) 135,
      (byte) 135,
      (byte) 133,
      (byte) 133,
      (byte) 186,
      (byte) 187,
      (byte) 184,
      (byte) 185,
      (byte) 190,
      (byte) 191,
      (byte) 188,
      (byte) 188,
      (byte) 179,
      (byte) 178,
      (byte) 176,
      (byte) 176,
      (byte) 182,
      (byte) 183,
      (byte) 180,
      (byte) 181,
      (byte) 170,
      (byte) 171,
      (byte) 168,
      (byte) 169,
      (byte) 175,
      (byte) 174,
      (byte) 172,
      (byte) 173,
      (byte) 163,
      (byte) 163,
      (byte) 160,
      (byte) 161,
      (byte) 166,
      (byte) 167,
      (byte) 164,
      (byte) 165,
      (byte) 219,
      (byte) 218,
      (byte) 216,
      (byte) 217,
      (byte) 222,
      (byte) 222,
      (byte) 220,
      (byte) 221,
      (byte) 210,
      (byte) 211,
      (byte) 208,
      (byte) 209,
      (byte) 215,
      (byte) 214,
      (byte) 212,
      (byte) 213,
      (byte) 202,
      (byte) 203,
      (byte) 201,
      (byte) 201,
      (byte) 206,
      (byte) 207,
      (byte) 204,
      (byte) 205,
      (byte) 195,
      (byte) 194,
      (byte) 192,
      (byte) 193,
      (byte) 198,
      (byte) 199,
      (byte) 196,
      (byte) 196,
      (byte) 250,
      (byte) 251,
      (byte) 248,
      (byte) 249,
      byte.MaxValue,
      (byte) 254,
      (byte) 252,
      (byte) 253,
      (byte) 242,
      (byte) 243,
      (byte) 240,
      (byte) 241,
      (byte) 247,
      (byte) 247,
      (byte) 244,
      (byte) 245,
      (byte) 235,
      (byte) 234,
      (byte) 232,
      (byte) 233,
      (byte) 238,
      (byte) 239,
      (byte) 236,
      (byte) 237,
      (byte) 226,
      (byte) 226,
      (byte) 224,
      (byte) 225,
      (byte) 231,
      (byte) 230,
      (byte) 228,
      (byte) 229,
      (byte) 26,
      (byte) 27,
      (byte) 24,
      (byte) 25,
      (byte) 30,
      (byte) 31,
      (byte) 29,
      (byte) 29,
      (byte) 19,
      (byte) 18,
      (byte) 16,
      (byte) 17,
      (byte) 22,
      (byte) 23,
      (byte) 20,
      (byte) 21,
      (byte) 10,
      (byte) 11,
      (byte) 8,
      (byte) 8,
      (byte) 14,
      (byte) 14,
      (byte) 13,
      (byte) 13,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 1,
      (byte) 6,
      (byte) 7,
      (byte) 4,
      (byte) 5,
      (byte) 58,
      (byte) 58,
      (byte) 57,
      (byte) 57,
      (byte) 62,
      (byte) 62,
      (byte) 60,
      (byte) 61,
      (byte) 50,
      (byte) 51,
      (byte) 48,
      (byte) 49,
      (byte) 54,
      (byte) 54,
      (byte) 53,
      (byte) 53,
      (byte) 42,
      (byte) 43,
      (byte) 41,
      (byte) 41,
      (byte) 46,
      (byte) 47,
      (byte) 44,
      (byte) 45,
      (byte) 34,
      (byte) 34,
      (byte) 33,
      (byte) 33,
      (byte) 38,
      (byte) 39,
      (byte) 36,
      (byte) 36,
      (byte) 90,
      (byte) 91,
      (byte) 88,
      (byte) 89,
      (byte) 94,
      (byte) 94,
      (byte) 93,
      (byte) 93,
      (byte) 82,
      (byte) 83,
      (byte) 80,
      (byte) 81,
      (byte) 87,
      (byte) 87,
      (byte) 84,
      (byte) 85,
      (byte) 74,
      (byte) 74,
      (byte) 73,
      (byte) 73,
      (byte) 78,
      (byte) 79,
      (byte) 76,
      (byte) 77,
      (byte) 66,
      (byte) 66,
      (byte) 64,
      (byte) 65,
      (byte) 70,
      (byte) 70,
      (byte) 69,
      (byte) 69,
      (byte) 122,
      (byte) 123,
      (byte) 120,
      (byte) 121,
      (byte) 126,
      (byte) 127,
      (byte) 125,
      (byte) 125,
      (byte) 114,
      (byte) 114,
      (byte) 113,
      (byte) 113,
      (byte) 118,
      (byte) 119,
      (byte) 116,
      (byte) 117,
      (byte) 106,
      (byte) 107,
      (byte) 104,
      (byte) 104,
      (byte) 110,
      (byte) 111,
      (byte) 108,
      (byte) 109,
      (byte) 99,
      (byte) 99,
      (byte) 96,
      (byte) 97,
      (byte) 102,
      (byte) 103,
      (byte) 101,
      (byte) 101,
      (byte) 154,
      (byte) 155,
      (byte) 152,
      (byte) 153,
      (byte) 158,
      (byte) 158,
      (byte) 156,
      (byte) 157,
      (byte) 146,
      (byte) 147,
      (byte) 145,
      (byte) 145,
      (byte) 150,
      (byte) 151,
      (byte) 148,
      (byte) 149,
      (byte) 138,
      (byte) 139,
      (byte) 137,
      (byte) 137,
      (byte) 142,
      (byte) 143,
      (byte) 141,
      (byte) 141,
      (byte) 130,
      (byte) 131,
      unchecked((byte) sbyte.MinValue),
      (byte) 129,
      (byte) 134,
      (byte) 135,
      (byte) 132,
      (byte) 132,
      (byte) 186,
      (byte) 187,
      (byte) 185,
      (byte) 185,
      (byte) 190,
      (byte) 191,
      (byte) 188,
      (byte) 189,
      (byte) 178,
      (byte) 179,
      (byte) 176,
      (byte) 177,
      (byte) 183,
      (byte) 183,
      (byte) 181,
      (byte) 181,
      (byte) 170,
      (byte) 171,
      (byte) 168,
      (byte) 169,
      (byte) 174,
      (byte) 175,
      (byte) 172,
      (byte) 173,
      (byte) 162,
      (byte) 162,
      (byte) 161,
      (byte) 161,
      (byte) 167,
      (byte) 167,
      (byte) 164,
      (byte) 165,
      (byte) 218,
      (byte) 218,
      (byte) 216,
      (byte) 217,
      (byte) 222,
      (byte) 223,
      (byte) 221,
      (byte) 221,
      (byte) 211,
      (byte) 211,
      (byte) 208,
      (byte) 209,
      (byte) 214,
      (byte) 215,
      (byte) 213,
      (byte) 213,
      (byte) 202,
      (byte) 203,
      (byte) 201,
      (byte) 201,
      (byte) 207,
      (byte) 207,
      (byte) 204,
      (byte) 205,
      (byte) 194,
      (byte) 195,
      (byte) 192,
      (byte) 192,
      (byte) 198,
      (byte) 199,
      (byte) 197,
      (byte) 197,
      (byte) 251,
      (byte) 251,
      (byte) 248,
      (byte) 249,
      (byte) 254,
      byte.MaxValue,
      (byte) 252,
      (byte) 253,
      (byte) 243,
      (byte) 243,
      (byte) 241,
      (byte) 241,
      (byte) 247,
      (byte) 247,
      (byte) 244,
      (byte) 245,
      (byte) 234,
      (byte) 235,
      (byte) 232,
      (byte) 233,
      (byte) 238,
      (byte) 238,
      (byte) 237,
      (byte) 237,
      (byte) 226,
      (byte) 226,
      (byte) 224,
      (byte) 225,
      (byte) 230,
      (byte) 230,
      (byte) 228,
      (byte) 229,
      (byte) 26,
      (byte) 27,
      (byte) 25,
      (byte) 25,
      (byte) 30,
      (byte) 30,
      (byte) 28,
      (byte) 29,
      (byte) 18,
      (byte) 19,
      (byte) 17,
      (byte) 17,
      (byte) 22,
      (byte) 23,
      (byte) 21,
      (byte) 21,
      (byte) 10,
      (byte) 10,
      (byte) 8,
      (byte) 9,
      (byte) 14,
      (byte) 15,
      (byte) 12,
      (byte) 12,
      (byte) 2,
      (byte) 3,
      (byte) 1,
      (byte) 1,
      (byte) 6,
      (byte) 6,
      (byte) 4,
      (byte) 5,
      (byte) 58,
      (byte) 59,
      (byte) 56,
      (byte) 57,
      (byte) 63,
      (byte) 63,
      (byte) 61,
      (byte) 61,
      (byte) 50,
      (byte) 51,
      (byte) 49,
      (byte) 49,
      (byte) 54,
      (byte) 54,
      (byte) 52,
      (byte) 53,
      (byte) 42,
      (byte) 43,
      (byte) 41,
      (byte) 41,
      (byte) 46,
      (byte) 47,
      (byte) 45,
      (byte) 45,
      (byte) 34,
      (byte) 35,
      (byte) 33,
      (byte) 33,
      (byte) 38,
      (byte) 39,
      (byte) 37,
      (byte) 37,
      (byte) 90,
      (byte) 91,
      (byte) 89,
      (byte) 89,
      (byte) 94,
      (byte) 95,
      (byte) 92,
      (byte) 92,
      (byte) 82,
      (byte) 83,
      (byte) 81,
      (byte) 81,
      (byte) 86,
      (byte) 87,
      (byte) 85,
      (byte) 85,
      (byte) 74,
      (byte) 75,
      (byte) 72,
      (byte) 73,
      (byte) 79,
      (byte) 79,
      (byte) 77,
      (byte) 77,
      (byte) 66,
      (byte) 67,
      (byte) 65,
      (byte) 65,
      (byte) 70,
      (byte) 71,
      (byte) 68,
      (byte) 69,
      (byte) 122,
      (byte) 122,
      (byte) 121,
      (byte) 121,
      (byte) 126,
      (byte) 127,
      (byte) 124,
      (byte) 125,
      (byte) 114,
      (byte) 115,
      (byte) 112,
      (byte) 113,
      (byte) 118,
      (byte) 119,
      (byte) 116,
      (byte) 117,
      (byte) 106,
      (byte) 106,
      (byte) 104,
      (byte) 105,
      (byte) 110,
      (byte) 111,
      (byte) 108,
      (byte) 109,
      (byte) 98,
      (byte) 99,
      (byte) 96,
      (byte) 97,
      (byte) 103,
      (byte) 103,
      (byte) 100,
      (byte) 101,
      (byte) 154,
      (byte) 155,
      (byte) 152,
      (byte) 153,
      (byte) 158,
      (byte) 159,
      (byte) 156,
      (byte) 157,
      (byte) 210,
      (byte) 214,
      (byte) 206,
      (byte) 194,
      (byte) 206,
      (byte) 248,
      (byte) 199,
      (byte) 196,
      (byte) 200,
      (byte) 223,
      (byte) 231,
      (byte) 194,
      (byte) 142,
      (byte) 194,
      (byte) 146,
      (byte) 223,
      (byte) 223,
      (byte) 195,
      (byte) 249,
      (byte) 223,
      (byte) 192,
      (byte) 214,
      (byte) 216,
      (byte) 220,
      (byte) 238,
      (byte) 171,
      (byte) 248,
      (byte) 224,
      (byte) 237,
      (byte) 251,
      (byte) 249,
      byte.MaxValue,
      (byte) 231,
      (byte) 163,
      (byte) 230,
      (byte) 238,
      (byte) 244,
      (byte) 234,
      (byte) 229,
      (byte) 241,
      (byte) 187,
      (byte) 224,
      (byte) 168,
      (byte) 163,
      (byte) 230,
      (byte) 173,
      (byte) 225,
      (byte) 203,
      (byte) 247,
      (byte) 225,
      (byte) 249,
      (byte) 247,
      byte.MaxValue,
      (byte) 244,
      (byte) 245,
      (byte) 225,
      (byte) 131,
      (byte) 132,
      (byte) 134,
      (byte) 201,
      (byte) 158,
      (byte) 142,
      (byte) 159,
      (byte) 158,
      (byte) 135,
      (byte) 135,
      (byte) 192,
      (byte) 207,
      (byte) 200,
      (byte) 201,
      (byte) 178,
      unchecked((byte) sbyte.MinValue),
      (byte) 136,
      (byte) 146,
      (byte) 158,
      (byte) 144,
      (byte) 157,
      (byte) 158,
      (byte) 136,
      (byte) 148,
      (byte) 157,
      (byte) 157,
      (byte) 208,
      (byte) 152,
      (byte) 152,
      (byte) 145,
      (byte) 155,
      (byte) 163,
      (byte) 175,
      (byte) 185,
      (byte) 161,
      (byte) 175,
      (byte) 167,
      (byte) 172,
      (byte) 173,
      (byte) 185,
      (byte) 171,
      (byte) 172,
      (byte) 174,
      (byte) 225,
      (byte) 160,
      (byte) 166,
      (byte) 173,
      (byte) 169,
      (byte) 191,
      (byte) 191,
      (byte) 248,
      (byte) 247,
      (byte) 240,
      (byte) 241,
      (byte) 138,
      (byte) 184,
      (byte) 160,
      (byte) 186,
      (byte) 182,
      (byte) 184,
      (byte) 181,
      (byte) 182,
      (byte) 160,
      (byte) 188,
      (byte) 69,
      (byte) 69,
      (byte) 8,
      (byte) 76,
      (byte) 92,
      (byte) 93,
      (byte) 67,
      (byte) 95,
      (byte) 3,
      (byte) 76,
      (byte) 80,
      (byte) 68,
      (byte) 72,
      (byte) 97,
      (byte) 77,
      (byte) 73,
      (byte) 95,
      (byte) 127,
      (byte) 81,
      (byte) 88,
      (byte) 82,
      (byte) 80,
      (byte) 91,
      (byte) 12,
      (byte) 126,
      (byte) 92,
      (byte) 81,
      (byte) 85,
      (byte) 22,
      (byte) 71,
      (byte) 65,
      (byte) 91,
      (byte) 105,
      (byte) 99,
      (byte) 109,
      (byte) 123,
      (byte) 46,
      (byte) 108,
      (byte) 109,
      (byte) 127,
      (byte) 102,
      (byte) 113,
      (byte) 101,
      (byte) 96,
      (byte) 98,
      (byte) 88,
      (byte) 116,
      (byte) 112,
      (byte) 116,
      (byte) 120,
      (byte) 112,
      (byte) 70,
      (byte) 125,
      (byte) 126,
      (byte) 110,
      (byte) 121,
      (byte) 77,
      (byte) 113,
      (byte) 101,
      (byte) 101,
      (byte) 98,
      (byte) 120,
      (byte) 122,
      (byte) 71,
      (byte) 15,
      (byte) 10,
      (byte) 12,
      (byte) 73,
      (byte) 30,
      (byte) 26,
      (byte) 2,
      (byte) 14,
      (byte) 10,
      (byte) 67,
      (byte) 3,
      (byte) 0,
      (byte) 20,
      (byte) 3,
      (byte) 23,
      (byte) 55,
      (byte) 31,
      (byte) 26,
      (byte) 28,
      (byte) 28,
      (byte) 12,
      (byte) 57,
      (byte) 19,
      (byte) 15,
      (byte) 31,
      (byte) 35,
      (byte) 5,
      (byte) 31,
      (byte) 21,
      (byte) 31,
      (byte) 84,
      (byte) 22,
      (byte) 43,
      (byte) 57,
      (byte) 44,
      (byte) 105,
      (byte) 60,
      (byte) 42,
      (byte) 45,
      (byte) 41,
      (byte) 39,
      (byte) 49,
      (byte) 16,
      (byte) 40,
      (byte) 54,
      (byte) 34,
      (byte) 100,
      (byte) 38,
      (byte) 53,
      (byte) 54,
      (byte) 53,
      (byte) 44,
      (byte) 48,
      (byte) 54,
      (byte) 63,
      (byte) 60,
      (byte) 38,
      (byte) 58,
      (byte) 63,
      (byte) 63,
      (byte) 118,
      (byte) 49,
      (byte) 53,
      (byte) 60,
      (byte) 198,
      (byte) 206,
      (byte) 204,
      (byte) 136,
      unchecked((byte) sbyte.MinValue),
      (byte) 234,
      (byte) 223,
      (byte) 200,
      (byte) 214,
      (byte) 224,
      (byte) 210,
      (byte) 192,
      (byte) 197,
      (byte) 204,
      (byte) 201,
      (byte) 192,
      (byte) 234,
      (byte) 210,
      (byte) 200,
      (byte) 220,
      (byte) 233,
      (byte) 205,
      (byte) 213,
      (byte) 201,
      (byte) 215,
      (byte) 147,
      (byte) 196,
      (byte) 216,
      (byte) 219,
      (byte) 210,
      (byte) 219,
      (byte) 192,
      (byte) 254,
      (byte) 170,
      (byte) 218,
      (byte) 236,
      (byte) 239,
      (byte) 235,
      (byte) 172,
      (byte) 249,
      (byte) 235,
      (byte) 238,
      (byte) 229,
      (byte) 238,
      (byte) 243,
      (byte) 243,
      (byte) 165,
      (byte) 196,
      (byte) 180,
      (byte) 254,
      (byte) 219,
      (byte) 175,
      (byte) 171,
      (byte) 174,
      (byte) 175,
      (byte) 165,
      (byte) 162,
      (byte) 164,
      (byte) 189,
      (byte) 168,
      (byte) 208,
      (byte) 174,
      (byte) 167,
      (byte) 184,
      (byte) 222,
      (byte) 170,
      (byte) 219,
      (byte) 209,
      (byte) 195,
      (byte) 174,
      (byte) 216,
      (byte) 223,
      (byte) 208,
      (byte) 206,
      (byte) 217,
      (byte) 167,
      (byte) 215,
      (byte) 162,
      (byte) 162,
      (byte) 221,
      (byte) 188,
      (byte) 200,
      (byte) 200,
      (byte) 188,
      (byte) 201,
      (byte) 207,
      (byte) 189,
      (byte) 147,
      (byte) 157,
      (byte) 135,
      (byte) 152,
      (byte) 148,
      (byte) 132,
      (byte) 215,
      (byte) 157,
      (byte) 155,
      (byte) 185,
      (byte) 191,
      (byte) 169,
      (byte) 167,
      (byte) 173,
      (byte) 170,
      (byte) 236,
      (byte) 164,
      (byte) 177,
      (byte) 227,
      (byte) 161,
      (byte) 173,
      (byte) 180,
      (byte) 162,
      (byte) 165,
      (byte) 161,
      (byte) 163,
      (byte) 251,
      (byte) 170,
      (byte) 172,
      (byte) 176,
      (byte) 177,
      (byte) 181,
      (byte) 179,
      (byte) 181,
      (byte) 253,
      (byte) 148,
      (byte) 168,
      (byte) 184,
      (byte) 154,
      (byte) 177,
      (byte) 161,
      (byte) 66,
      (byte) 68,
      (byte) 76,
      (byte) 7,
      (byte) 106,
      (byte) 86,
      (byte) 66,
      (byte) 96,
      (byte) 71,
      (byte) 87,
      (byte) 72,
      (byte) 78,
      (byte) 66,
      (byte) 97,
      (byte) 69,
      (byte) 70,
      (byte) 78,
      (byte) 84,
      (byte) 74,
      (byte) 64,
      (byte) 93,
      (byte) 77,
      (byte) 89,
      (byte) 92,
      (byte) 70,
      (byte) 86,
      (byte) 125,
      (byte) 84,
      (byte) 66,
      (byte) 95,
      (byte) 91,
      (byte) 81,
      (byte) 113,
      (byte) 43,
      (byte) 101,
      (byte) 96,
      (byte) 46,
      (byte) 50,
      (byte) 44,
      (byte) 33,
      (byte) 34,
      (byte) 98,
      (byte) 116,
      (byte) 117,
      (byte) 116,
      (byte) 110,
      (byte) 102,
      (byte) 112,
      (byte) 110,
      (byte) 126,
      (byte) 107,
      (byte) 57,
      (byte) 35,
      (byte) 63,
      (byte) 60,
      (byte) 96,
      (byte) 105,
      (byte) 51,
      (byte) 93,
      (byte) 120,
      (byte) 54,
      (byte) 42,
      (byte) 52,
      (byte) 57,
      (byte) 74,
      (byte) 42,
      (byte) 28,
      (byte) 29,
      (byte) 28,
      (byte) 6,
      (byte) 14,
      (byte) 24,
      (byte) 22,
      (byte) 6,
      (byte) 64,
      (byte) 92,
      (byte) 70
        };

        static PunchCardReader()
        {
            int index = 0;
            label_10:
            int num1 = -297494778;
            while (true)
            {
                int num2 = -297494781;
                switch (num1 ^ num2)
                {
                    case 0:
                        int num3;
                        int num4;
                        if (index >= PunchCardReader.byte_0.Length)
                        {
                            int num5 = -297494782;
                            num4 = -297494782;
                            num3 = num5;
                        }
                        else
                        {
                            num3 = -297494784;
                            num4 = -297494784;
                        }
                        num1 = num3;
                        continue;
                    case 1:
                        goto label_9;
                    case 2:
                        ++index;
                        num1 = -297494781;
                        continue;
                    case 3:
                        PunchCardReader.byte_0[index] = (byte)((int)PunchCardReader.byte_0[index] ^ index ^ 170);
                        num1 = -297494783;
                        continue;
                    case 4:
                        goto label_10;
                    case 5:
                        num1 = -297494781;
                        continue;
                    default:
                        goto label_11;
                }
            }
            label_11:
            return;
            label_9:;
        }

        private static string smethod_0(int int_0, int int_1, int int_2)
        {
            string @string = Encoding.UTF8.GetString(PunchCardReader.byte_0, int_1, int_2);
            PunchCardReader.string_0[int_0] = @string;
            return @string;
        }

        public static string smethod_1()
        {
            return PunchCardReader.string_0[0] ?? PunchCardReader.smethod_0(0, 0, 12);
        }

        public static string smethod_2()
        {
            return PunchCardReader.string_0[1] ?? PunchCardReader.smethod_0(1, 12, 12);
        }

        public static string smethod_3()
        {
            return PunchCardReader.string_0[2] ?? PunchCardReader.smethod_0(2, 24, 12);
        }

        public static string smethod_4()
        {
            return PunchCardReader.string_0[3] ?? PunchCardReader.smethod_0(3, 36, 12);
        }

        public static string smethod_5()
        {
            return PunchCardReader.string_0[4] ?? PunchCardReader.smethod_0(4, 48, 12);
        }

        public static string smethod_6()
        {
            return PunchCardReader.string_0[5] ?? PunchCardReader.smethod_0(5, 60, 12);
        }

        public static string smethod_7()
        {
            return PunchCardReader.string_0[6] ?? PunchCardReader.smethod_0(6, 72, 12);
        }

        public static string smethod_8()
        {
            return PunchCardReader.string_0[7] ?? PunchCardReader.smethod_0(7, 84, 12);
        }

        public static string smethod_9()
        {
            return PunchCardReader.string_0[8] ?? PunchCardReader.smethod_0(8, 96, 12);
        }

        public static string smethod_10()
        {
            return PunchCardReader.string_0[9] ?? PunchCardReader.smethod_0(9, 108, 12);
        }

        public static string smethod_11()
        {
            return PunchCardReader.string_0[10] ?? PunchCardReader.smethod_0(10, 120, 12);
        }

        public static string smethod_12()
        {
            return PunchCardReader.string_0[11] ?? PunchCardReader.smethod_0(11, 132, 12);
        }

        public static string smethod_13()
        {
            return PunchCardReader.string_0[12] ?? PunchCardReader.smethod_0(12, 144, 12);
        }

        public static string smethod_14()
        {
            return PunchCardReader.string_0[13] ?? PunchCardReader.smethod_0(13, 156, 12);
        }

        public static string smethod_15()
        {
            return PunchCardReader.string_0[14] ?? PunchCardReader.smethod_0(14, 168, 12);
        }

        public static string smethod_16()
        {
            return PunchCardReader.string_0[15] ?? PunchCardReader.smethod_0(15, 180, 12);
        }

        public static string smethod_17()
        {
            return PunchCardReader.string_0[16] ?? PunchCardReader.smethod_0(16, 192, 12);
        }

        public static string smethod_18()
        {
            return PunchCardReader.string_0[17] ?? PunchCardReader.smethod_0(17, 204, 12);
        }

        public static string smethod_19()
        {
            return PunchCardReader.string_0[18] ?? PunchCardReader.smethod_0(18, 216, 12);
        }

        public static string smethod_20()
        {
            return PunchCardReader.string_0[19] ?? PunchCardReader.smethod_0(19, 228, 12);
        }

        public static string smethod_21()
        {
            return PunchCardReader.string_0[20] ?? PunchCardReader.smethod_0(20, 240, 12);
        }

        public static string smethod_22()
        {
            return PunchCardReader.string_0[21] ?? PunchCardReader.smethod_0(21, 252, 12);
        }

        public static string smethod_23()
        {
            return PunchCardReader.string_0[22] ?? PunchCardReader.smethod_0(22, 264, 12);
        }

        public static string smethod_24()
        {
            return PunchCardReader.string_0[23] ?? PunchCardReader.smethod_0(23, 276, 12);
        }

        public static string smethod_25()
        {
            return PunchCardReader.string_0[24] ?? PunchCardReader.smethod_0(24, 288, 12);
        }

        public static string smethod_26()
        {
            return PunchCardReader.string_0[25] ?? PunchCardReader.smethod_0(25, 300, 12);
        }

        public static string smethod_27()
        {
            return PunchCardReader.string_0[26] ?? PunchCardReader.smethod_0(26, 312, 12);
        }

        public static string smethod_28()
        {
            return PunchCardReader.string_0[27] ?? PunchCardReader.smethod_0(27, 324, 12);
        }

        public static string smethod_29()
        {
            return PunchCardReader.string_0[28] ?? PunchCardReader.smethod_0(28, 336, 12);
        }

        public static string smethod_30()
        {
            return PunchCardReader.string_0[29] ?? PunchCardReader.smethod_0(29, 348, 12);
        }

        public static string smethod_31()
        {
            return PunchCardReader.string_0[30] ?? PunchCardReader.smethod_0(30, 360, 12);
        }

        public static string smethod_32()
        {
            return PunchCardReader.string_0[31] ?? PunchCardReader.smethod_0(31, 372, 12);
        }

        public static string smethod_33()
        {
            return PunchCardReader.string_0[32] ?? PunchCardReader.smethod_0(32, 384, 12);
        }

        public static string smethod_34()
        {
            return PunchCardReader.string_0[33] ?? PunchCardReader.smethod_0(33, 396, 12);
        }

        public static string smethod_35()
        {
            return PunchCardReader.string_0[34] ?? PunchCardReader.smethod_0(34, 408, 12);
        }

        public static string smethod_36()
        {
            return PunchCardReader.string_0[35] ?? PunchCardReader.smethod_0(35, 420, 12);
        }

        public static string smethod_37()
        {
            return PunchCardReader.string_0[36] ?? PunchCardReader.smethod_0(36, 432, 12);
        }

        public static string smethod_38()
        {
            return PunchCardReader.string_0[37] ?? PunchCardReader.smethod_0(37, 444, 12);
        }

        public static string smethod_39()
        {
            return PunchCardReader.string_0[38] ?? PunchCardReader.smethod_0(38, 456, 12);
        }

        public static string smethod_40()
        {
            return PunchCardReader.string_0[39] ?? PunchCardReader.smethod_0(39, 468, 12);
        }

        public static string smethod_41()
        {
            return PunchCardReader.string_0[40] ?? PunchCardReader.smethod_0(40, 480, 12);
        }

        public static string smethod_42()
        {
            return PunchCardReader.string_0[41] ?? PunchCardReader.smethod_0(41, 492, 12);
        }

        public static string smethod_43()
        {
            return PunchCardReader.string_0[42] ?? PunchCardReader.smethod_0(42, 504, 12);
        }

        public static string smethod_44()
        {
            return PunchCardReader.string_0[43] ?? PunchCardReader.smethod_0(43, 516, 12);
        }

        public static string smethod_45()
        {
            return PunchCardReader.string_0[44] ?? PunchCardReader.smethod_0(44, 528, 12);
        }

        public static string smethod_46()
        {
            return PunchCardReader.string_0[45] ?? PunchCardReader.smethod_0(45, 540, 12);
        }

        public static string smethod_47()
        {
            return PunchCardReader.string_0[46] ?? PunchCardReader.smethod_0(46, 552, 12);
        }

        public static string smethod_48()
        {
            return PunchCardReader.string_0[47] ?? PunchCardReader.smethod_0(47, 564, 12);
        }

        public static string smethod_49()
        {
            return PunchCardReader.string_0[48] ?? PunchCardReader.smethod_0(48, 576, 12);
        }

        public static string smethod_50()
        {
            return PunchCardReader.string_0[49] ?? PunchCardReader.smethod_0(49, 588, 12);
        }

        public static string smethod_51()
        {
            return PunchCardReader.string_0[50] ?? PunchCardReader.smethod_0(50, 600, 12);
        }

        public static string smethod_52()
        {
            return PunchCardReader.string_0[51] ?? PunchCardReader.smethod_0(51, 612, 12);
        }

        public static string smethod_53()
        {
            return PunchCardReader.string_0[52] ?? PunchCardReader.smethod_0(52, 624, 12);
        }

        public static string smethod_54()
        {
            return PunchCardReader.string_0[53] ?? PunchCardReader.smethod_0(53, 636, 12);
        }

        public static string smethod_55()
        {
            return PunchCardReader.string_0[54] ?? PunchCardReader.smethod_0(54, 648, 12);
        }

        public static string smethod_56()
        {
            return PunchCardReader.string_0[55] ?? PunchCardReader.smethod_0(55, 660, 12);
        }

        public static string smethod_57()
        {
            return PunchCardReader.string_0[56] ?? PunchCardReader.smethod_0(56, 672, 12);
        }

        public static string smethod_58()
        {
            return PunchCardReader.string_0[57] ?? PunchCardReader.smethod_0(57, 684, 12);
        }

        public static string smethod_59()
        {
            return PunchCardReader.string_0[58] ?? PunchCardReader.smethod_0(58, 696, 12);
        }

        public static string smethod_60()
        {
            return PunchCardReader.string_0[59] ?? PunchCardReader.smethod_0(59, 708, 12);
        }

        public static string smethod_61()
        {
            return PunchCardReader.string_0[60] ?? PunchCardReader.smethod_0(60, 720, 12);
        }

        public static string smethod_62()
        {
            return PunchCardReader.string_0[61] ?? PunchCardReader.smethod_0(61, 732, 12);
        }

        public static string smethod_63()
        {
            return PunchCardReader.string_0[62] ?? PunchCardReader.smethod_0(62, 744, 12);
        }

        public static string smethod_64()
        {
            return PunchCardReader.string_0[63] ?? PunchCardReader.smethod_0(63, 756, 12);
        }

        public static string smethod_65()
        {
            return PunchCardReader.string_0[64] ?? PunchCardReader.smethod_0(64, 768, 12);
        }

        public static string smethod_66()
        {
            return PunchCardReader.string_0[65] ?? PunchCardReader.smethod_0(65, 780, 12);
        }

        public static string smethod_67()
        {
            return PunchCardReader.string_0[66] ?? PunchCardReader.smethod_0(66, 792, 12);
        }

        public static string smethod_68()
        {
            return PunchCardReader.string_0[67] ?? PunchCardReader.smethod_0(67, 804, 12);
        }

        public static string smethod_69()
        {
            return PunchCardReader.string_0[68] ?? PunchCardReader.smethod_0(68, 816, 12);
        }

        public static string smethod_70()
        {
            return PunchCardReader.string_0[69] ?? PunchCardReader.smethod_0(69, 828, 12);
        }

        public static string smethod_71()
        {
            return PunchCardReader.string_0[70] ?? PunchCardReader.smethod_0(70, 840, 12);
        }

        public static string smethod_72()
        {
            return PunchCardReader.string_0[71] ?? PunchCardReader.smethod_0(71, 852, 12);
        }

        public static string smethod_73()
        {
            return PunchCardReader.string_0[72] ?? PunchCardReader.smethod_0(72, 864, 12);
        }

        public static string smethod_74()
        {
            return PunchCardReader.string_0[73] ?? PunchCardReader.smethod_0(73, 876, 12);
        }

        public static string smethod_75()
        {
            return PunchCardReader.string_0[74] ?? PunchCardReader.smethod_0(74, 888, 12);
        }

        public static string smethod_76()
        {
            return PunchCardReader.string_0[75] ?? PunchCardReader.smethod_0(75, 900, 12);
        }

        public static string smethod_77()
        {
            return PunchCardReader.string_0[76] ?? PunchCardReader.smethod_0(76, 912, 12);
        }

        public static string smethod_78()
        {
            return PunchCardReader.string_0[77] ?? PunchCardReader.smethod_0(77, 924, 12);
        }

        public static string smethod_79()
        {
            return PunchCardReader.string_0[78] ?? PunchCardReader.smethod_0(78, 936, 12);
        }

        public static string smethod_80()
        {
            return PunchCardReader.string_0[79] ?? PunchCardReader.smethod_0(79, 948, 12);
        }

        public static string smethod_81()
        {
            return PunchCardReader.string_0[80] ?? PunchCardReader.smethod_0(80, 960, 12);
        }

        public static string smethod_82()
        {
            return PunchCardReader.string_0[81] ?? PunchCardReader.smethod_0(81, 972, 12);
        }

        public static string smethod_83()
        {
            return PunchCardReader.string_0[82] ?? PunchCardReader.smethod_0(82, 984, 12);
        }

        public static string smethod_84()
        {
            return PunchCardReader.string_0[83] ?? PunchCardReader.smethod_0(83, 996, 12);
        }

        public static string smethod_85()
        {
            return PunchCardReader.string_0[84] ?? PunchCardReader.smethod_0(84, 1008, 12);
        }

        public static string smethod_86()
        {
            return PunchCardReader.string_0[85] ?? PunchCardReader.smethod_0(85, 1020, 12);
        }

        public static string smethod_87()
        {
            return PunchCardReader.string_0[86] ?? PunchCardReader.smethod_0(86, 1032, 18);
        }

        public static string smethod_88()
        {
            return PunchCardReader.string_0[87] ?? PunchCardReader.smethod_0(87, 1050, 23);
        }

        public static string smethod_89()
        {
            return PunchCardReader.string_0[88] ?? PunchCardReader.smethod_0(88, 1073, 6);
        }

        public static string smethod_90()
        {
            return PunchCardReader.string_0[89] ?? PunchCardReader.smethod_0(89, 1079, 23);
        }

        public static string smethod_91()
        {
            return PunchCardReader.string_0[90] ?? PunchCardReader.smethod_0(90, 1102, 17);
        }

        public static string smethod_92()
        {
            return PunchCardReader.string_0[91] ?? PunchCardReader.smethod_0(91, 1119, 23);
        }

        public static string smethod_93()
        {
            return PunchCardReader.string_0[92] ?? PunchCardReader.smethod_0(92, 1142, 19);
        }

        public static string smethod_94()
        {
            return PunchCardReader.string_0[93] ?? PunchCardReader.smethod_0(93, 1161, 15);
        }

        public static string smethod_95()
        {
            return PunchCardReader.string_0[94] ?? PunchCardReader.smethod_0(94, 1176, 17);
        }

        public static string smethod_96()
        {
            return PunchCardReader.string_0[95] ?? PunchCardReader.smethod_0(95, 1193, 22);
        }

        public static string smethod_97()
        {
            return PunchCardReader.string_0[96] ?? PunchCardReader.smethod_0(96, 1215, 16);
        }

        public static string smethod_98()
        {
            return PunchCardReader.string_0[97] ?? PunchCardReader.smethod_0(97, 1231, 10);
        }

        public static string smethod_99()
        {
            return PunchCardReader.string_0[98] ?? PunchCardReader.smethod_0(98, 1241, 17);
        }

        public static string smethod_100()
        {
            return PunchCardReader.string_0[99] ?? PunchCardReader.smethod_0(99, 1258, 26);
        }

        public static string smethod_101()
        {
            return PunchCardReader.string_0[100] ?? PunchCardReader.smethod_0(100, 1284, 1);
        }

        public static string smethod_102()
        {
            return PunchCardReader.string_0[101] ?? PunchCardReader.smethod_0(101, 1285, 15);
        }

        public static string smethod_103()
        {
            return PunchCardReader.string_0[102] ?? PunchCardReader.smethod_0(102, 1300, 14);
        }

        public static string smethod_104()
        {
            return PunchCardReader.string_0[103] ?? PunchCardReader.smethod_0(103, 1314, 13);
        }

        public static string smethod_105()
        {
            return PunchCardReader.string_0[104] ?? PunchCardReader.smethod_0(104, 1327, 3);
        }

        public static string smethod_106()
        {
            return PunchCardReader.string_0[105] ?? PunchCardReader.smethod_0(105, 1330, 36);
        }

        public static string smethod_107()
        {
            return PunchCardReader.string_0[106] ?? PunchCardReader.smethod_0(106, 1366, 36);
        }

        public static string smethod_108()
        {
            return PunchCardReader.string_0[107] ?? PunchCardReader.smethod_0(107, 1402, 26);
        }

        public static string smethod_109()
        {
            return PunchCardReader.string_0[108] ?? PunchCardReader.smethod_0(108, 1428, 12);
        }

        public static string smethod_110()
        {
            return PunchCardReader.string_0[109] ?? PunchCardReader.smethod_0(109, 1440, 7);
        }

        public static string smethod_111()
        {
            return PunchCardReader.string_0[110] ?? PunchCardReader.smethod_0(110, 1447, 15);
        }

        public static string smethod_112()
        {
            return PunchCardReader.string_0[111] ?? PunchCardReader.smethod_0(111, 1462, 2);
        }

        public static string smethod_113()
        {
            return PunchCardReader.string_0[112] ?? PunchCardReader.smethod_0(112, 1464, 7);
        }

        public static string smethod_114()
        {
            return PunchCardReader.string_0[113] ?? PunchCardReader.smethod_0(113, 1471, 14);
        }
    }
}
