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

		private Panel LnbContents;
		public Panel _LnbContents
		{
			get
			{
				return LnbContents;
			}
			set
			{
				LnbContents = _LnbContents;
			}
		}

		public LnbButtonInfo() : this(null, null, null)
		{

		}

		public LnbButtonInfo(Panel LnbPanel, Label LnbLabel, Panel LnbContents)
		{
			this.LnbPanel = LnbPanel;
			this.LnbLabel = LnbLabel;
			this.LnbContents = LnbContents;
		}

	}
}
