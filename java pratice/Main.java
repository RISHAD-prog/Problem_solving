class Main { 
 static int i; 
 static { 
 i = 10; 
 System.out.println("static block called "); 
 } 
 public static void main(String args[]) { 
	 System.out.println(Main.i);
	 }
}
//class Main {
//	public static void main(String args[]) { 
//		 System.out.println(Test.i);
//		 }
//
//}
