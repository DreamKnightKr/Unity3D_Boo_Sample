import UnityEngine
import System.Collections

class HelloBoo (MonoBehaviour):
	public obj as GameObject 

	def Start ():
		pass
	
	def Update ():
		pass
		
	def PrintOnConsol(str as string) :
		print(str)

	def PrintHelloBoo():
		PrintOnConsol(GetHelloBoo())

	def GetHelloBoo() as string :
		return "HelloBoo"
		
	def SendMessageToCShapComponent():
		// -> print "SendMessageToCShapComponent"	// Don't Show on consol
		print ("SendMessageToCShapComponent")
		obj = GameObject.Find("GameObjectWithC#")
		obj.GetComponent("CShapDemo").SendMessage("CallFromHellBoo", "Call OK !!!")
		
	def ReturnValue(obj as Hashtable):
		obj["Return"] = "Return String"
		
		
