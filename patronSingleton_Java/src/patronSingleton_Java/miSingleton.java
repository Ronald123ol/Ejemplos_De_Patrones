package patronSingleton_Java;
public  class miSingleton {
	String x;
	
	public String getX() {
		return x;
	}

	public void setX(String x) {
		this.x = x;
	}

	private static miSingleton mySingleton;
	
	private miSingleton(String x) {
		this.x=x;
	}
	
	public static miSingleton getmiSingleton(String x){
		if (mySingleton == null) {
			mySingleton = new miSingleton(x);
		}
		return mySingleton;
	}
	
	
}


