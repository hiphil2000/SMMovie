using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SM_Movie.Model
{
	class LnbButtonInfo
	{
		private Panel LnbPanel;
		public Panel _LnbPanel
		{
			get
			{
				return LnbPanel;
			}
			set
			{
				LnbPanel = _LnbPanel;
			}
		}
		private Label LnbLabel;
		public Label _LnbLabel
		{
			get
			{
				return LnbLabel;
			}
			set
			{
				LnbLabel = _LnbLabel;
			}
		}

		private string LnbTable;
		public string _LnbTable
		{
			get
			{
				return LnbTable;
			}
			set
			{
                LnbTable = _LnbTable;
			}
		}

		public LnbButtonInfo() : this(null, null, null)
		{

		}

		public LnbButtonInfo(Panel LnbPanel, Label LnbLabel, string LnbTable)
		{
			this.LnbPanel = LnbPanel;
			this.LnbLabel = LnbLabel;
            this.LnbTable = LnbTable;
		}

	}
}
