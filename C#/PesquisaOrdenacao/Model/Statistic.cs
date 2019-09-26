namespace PesquisaOrdenacao
{
	public class Statistic
	{	
		private string methodName;
		private string time;
		private string comparations;
		private string exchanges;

		public Statistic(string methodName, string time, string comparations, string exchanges){
			this.methodName = methodName;
			this.time = time;
			this.comparations = comparations;
			this.exchanges = exchanges;
		}

		public string getStatistic(){
			return methodName+";"+time+";"+comparations+";"+exchanges;
		}
	}
}