using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
	public class SuccessDataResult<T> : DataResult<T>
	{
		// Hata mesajı ve veri ile başarısız bir sonucu temsil eden constructor.
		public SuccessDataResult(T data, string message) : base(data, true, message)
		{
		}

		// Hata mesajı ve veri olmadan başarısız bir sonucu temsil eden constructor.
		public SuccessDataResult(T data) : base(data, true)
		{
		}

		// Hata mesajı ile başarısız bir sonucu temsil eden constructor (veri olmadan).
		public SuccessDataResult(string message) : base(default, true, message)
		{
		}

		// Başarısız bir sonucu temsil eder (ne veri ne de mesaj).
		public SuccessDataResult() : base(default, true)
		{
		}
	}
}
