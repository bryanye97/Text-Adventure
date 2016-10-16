using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0, stairs_0, floor, closet_door, stairs_1, corridor_1, in_closet, stairs_2, corridor_2, corridor_3, courtyard};
	private States myState;

	// Use this for initialization
	void Start () {
		text.text = "Hello World";
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {
			cell ();
		} else if (myState == States.sheets_0) {
			sheets_0 ();
		} else if (myState == States.mirror) {
			mirror ();
		} else if (myState == States.lock_0) {
			lock_0 ();
		} else if (myState == States.sheets_1) {
			sheets_1 ();
		} else if (myState == States.cell_mirror) {
			cell_mirror ();
		} else if (myState == States.lock_1) {
			lock_1 ();
		} else if (myState == States.corridor_0) {
			corridor_0 ();
		} else if (myState == States.stairs_0) {
			stairs_0 ();
		} else if (myState == States.floor) {
			floor ();
		} else if (myState == States.closet_door) {
			closet_door ();
		} else if (myState == States.stairs_1) {
			stairs_1 ();
		} else if (myState == States.corridor_1) {
			corridor_1 ();
		} else if (myState == States.in_closet) {
			in_closet ();
		} else if (myState == States.stairs_2) {
			stairs_2 ();
		} else if (myState == States.corridor_2) {
			corridor_2 ();
		} else if (myState == States.corridor_3) {
			corridor_3 ();
		} else if (myState == States.courtyard) {
			courtyard ();
		}
	}

	void cell () {
		text.text = "You are in a prison cell, and you want to escape. " +
			"There are some dirty sheets on the bed, a mirror on the wall, " +
			"and the door is locked from the outside. \n\n " +
			"Press S to view Sheets, M to view Mirror or L to view Lock.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0	;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.mirror	;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_0	;
		}
	} 

	void sheets_0 () {
		text.text = "You can't believe you sleep in these things. " +
					"Surely it's time somebody changed them. " +
					"The pleasures of prison life I guess! \n\n " +
					"Press R to return roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		} 
	} 

	void mirror () {
		text.text = "You look inside the mirror. Somehow you can't see your own reflection. Is it really a mirror? Perhaps it could be used for something else. \n\n " +
					"Press T to take the mirror.";
		if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.cell_mirror;
		} 
	} 

	void lock_0 () {
		text.text = "You inspect the lock. This isn't an ordinary lock. I guess it's a way for them to keep criminals like you away. I wonder where the key is. \n\n " +
					"Press R to return roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		} 
	}

	void sheets_1 () {
		text.text = "You can't believe you sleep in these things. " +
					"Surely it's time somebody changed them. " +
					"The pleasures of prison life I guess! \n\n " +
					"Press R to return roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		} 
	} 

	void cell_mirror () {
		text.text = "You take the mirror. Or whatever this creepy thing is. " +
					"You still don't know why you can't see yourself. " +
					"Whatever, perhaps you've taken a step into the supernatural. Perhaps this isn't a mirror at all.\n\n " +
					"Press S to view Sheets or L to view Lock.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_1;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_1;
		}
	} 

	void lock_1 () {
		text.text = "You look at the lock once again. " +
					"Whoever made this lock is crazy. Perhaps the mirror has something to do with the lock. \n\n " +
					"Press P to place the mirror on the lock.";
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.corridor_0;
		} 
	} 

	void corridor_0 () {
		text.text = "The mirror glows and silently but violent vibrates against the lock. " +
					"You don't believe in mystical things, but perhaps this is new technology posing as the supernatural. " +
					"The lock vanishes. \n\n" +
					"You are now in a corridor \n\n "+ 
					"Press S to climb the stairs, F to inspect the Floor or C to inspect the Closet.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_0;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.floor;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_door;
		}
	} 

	void stairs_0 () {
		text.text = "The floorboards creek as you climb up these stone cold stairs." + 
					"You look around but don't find anything... except a guard! Return to the corridor now! \n\n" +
					"Press R to return to the corridor.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		}
	} 

	void floor () {
		text.text = "You look on the floor. There's nothing nothing special here really. " +
					"Just some dust, hair, dirt and oh... a hairclip. Perhaps we could use this to pick a lock. \n\n "+ 
					"Press T to take the hairclip.";
		if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.corridor_1;
		} 
	} 

	void closet_door () {
		text.text = "You try to open the closet door but there's a lock. If only you had something to pick the lock with." +
					"There's nothing left to do here I guess. \n\n "+ 
					"Press R to return to the corridor.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		} 
	} 

	void corridor_1 () {
		text.text = "You're back in the corridor. There's nothing left on the floor. " +
					"Perhaps you should check the stairs or the closet again.\n\n "+ 
					"Press S to climb the stairs or C to inspect the Closet.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_1;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.in_closet;
		}
	} 

	void stairs_1 () {
		text.text = "The floorboards creek as you climb up these stone cold stairs." + 
					"You look around but don't find anything... except a guard! Return to the corridor now! \n\n" +
				"Press R to return to the corridor.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_1;
		}
	} 

	void in_closet () {
		text.text = "You inspect the closet lock again. After some trouble breaking the lock, you remember you have a hairclip. " +
					"Luckily, your lockpicking skills come in handy and you break open the closet. You find a cleaners uniform, but nothing else special. \n\n " +
					"Press R to return to the corridor or D to dress as a cleaner.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_2;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.corridor_3;
		}
	} 

	void stairs_2 () {
		text.text = "The floorboards creek as you climb up these stone cold stairs." + 
					"You look around but don't find anything but the same guard watching it. Perhaps pretending to be a cleaner will work. \n\n" +
					"Press R to return to the corridor.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_2;
		}
	} 


	void corridor_2 () {
		text.text = "You're back in the corridor." +
			"Perhaps you should check the stairs or the closet again.\n\n "+ 
			"Press S to climb the stairs or C to inspect the Closet.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_1;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.in_closet;
		}
	} 

	void corridor_3 () {
		text.text = "You put the cleaner's uniform on. It looks ridiculous on you but whatever." +
			"Let's hope that annoying guard doesn't see us. \n\n "+ 
			"Press S to climb the Stairs.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.courtyard;
		} 
	} 

	void courtyard () {
		text.text = "You cautiously climb up the stairs with your cleaner uniform, each step sending a shiver throughout your body." +
			"You make eye contact with the guard watching. He doesn't seem to notice you're an inmate, or maybe he doesn't really care."+ 
			"Either way, you walk past him and into the courtyard! \n\n "+ 
			"Congratulations, you're finally free! \n\n "+ 
			"Press P to play again.";
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell;
		} 
	} 
}
