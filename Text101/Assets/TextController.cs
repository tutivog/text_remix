using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum State {welcome, prison_initial, prison_nokey, prison_key, prison_key_cloth, prison_key_failed, prison_key_cloth_back, mirror_nokey, mirror_getkey, mirror_key_cloth,  
		mirror_key, mirror_key_failed, door_nokey, door_key, door_key_cloth, door_failed, door_key_failed, bed_nokey, bed_key, bed_key_getcloth, bed_key_cloth, hallway_initial};
	private State state;

	int tried = 0;

	// Use this for initialization
	void Start ()
	{
		//Start函数下进行游戏初始化：欢迎界面
		state = State.welcome;
		if (state == State.welcome) {
			text.text = "欢迎来到监狱逃脱101\n按空格键开始";
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
		print (state);
		if (state == State.welcome) {
			state_welcome ();
		} else if (state == State.prison_initial) {
			state_prison_initial ();
		} else if (state == State.mirror_nokey) {
			state_mirror_nokey ();
		} else if (state == State.prison_nokey) {
			state_prison_nokey ();
		} else if (state == State.door_nokey) {
			state_door_nokey ();
		} else if (state == State.mirror_getkey) {
			state_mirror_getkey ();
		} else if (state == State.prison_key) {
			state_prison_key ();
		} else if (state == State.bed_nokey) {
			state_bed_nokey ();
		} else if (state == State.bed_key) {
			state_bed_key ();
		} else if (state == State.bed_key_getcloth) {
			state_bed_key_getcloth ();
		} else if (state == State.prison_key_cloth) {
			state_prison_key_cloth ();
		} else if (state == State.bed_key_cloth) {
			state_bed_key_cloth ();
		} else if (state == State.mirror_key_cloth) {
			state_mirror_key_cloth ();
		} else if (state == State.door_key_cloth) {
			state_door_key_cloth ();
		} else if (state == State.door_key_failed) {
			state_door_key_failed ();
		} else if (state == State.prison_key_failed) {
			state_prison_key_failed ();
		} else if (state == State.door_key) {
			state_door_key ();
		} else if (state == State.prison_key_cloth_back) {
			state_prison_key_cloth_back ();
		} else if (state == State.hallway_initial) {
			state_hallway_initial ();
		} else if (state == State.mirror_key) {
			state_mirror_key ();
		} else if (state == State.door_failed) {
			state_door_failed ();
		} else if (state == State.mirror_key_failed) {
			state_mirror_key_failed ();
		}



	}

	void state_welcome ()
	{
		if (Input.GetKeyDown ("space")) {
			state = State.prison_initial;
		}
	}

	void state_prison_initial ()
	{
		text.text = "你在一个监狱里醒来。周围有一张破旧的床，一面镜子和一扇铁门。\n" +
		"            按B走向床，M走向镜子，D走向门。";
		if (Input.GetKeyDown ("b")) {
			state = State.bed_nokey;
		} else if (Input.GetKeyDown ("m")) {
			state = State.mirror_nokey;
		} else if (Input.GetKeyDown ("d")) {
			state = State.door_nokey;
		}

	}

	void state_prison_nokey ()
	{
		text.text = "你回到了监狱的中间，一股强烈想要逃脱的念头涌了上来。直觉告诉你一定有一个逃出去的办法。\n" +
					"按B走向床，M走向镜子，D走向门";
		if (Input.GetKeyDown ("b")) {
			state = State.bed_nokey;
		} else if (Input.GetKeyDown ("m")) {
			state = State.mirror_nokey;
		} else if (Input.GetKeyDown ("d")) {
			state = State.door_nokey;
		}
	}

	void state_prison_key ()
	{
		text.text = "你回到了开始的地方，手里拿着捡到的玻璃片，你感觉自己又在通向自由的道路上走了一步。“如果冷静下来，一定可以逃出去的！”你这样想。\n按B走向床，M走向镜子，D走向门";
		if (Input.GetKeyDown ("b")) {
			state = State.bed_key;
		} else if (Input.GetKeyDown ("m")) {
			state = State.mirror_key;
		} else if (Input.GetKeyDown ("d")) {
			state = State.door_key;
		}
	}

	void state_prison_key_failed ()
	{
		text.text = "你回到了开始的地方，手里拿着捡到的玻璃片。“现在该怎么办呢？”\n按B走向床，M走向镜子，D走向门";
		if (Input.GetKeyDown ("b")) {
			state = State.bed_key;
		} else if (Input.GetKeyDown ("m")) {
			state = State.mirror_key_failed;
		} else if (Input.GetKeyDown ("d")) {
			state = State.door_failed;
		}
	}

	void state_prison_key_cloth ()
	{
		text.text = "还是同样的监狱，只不过你现在有了玻璃片和破布。你隐隐约约的感到自己离自由又近了一步，脚已经开始不自觉地迈了出去。\n按B走向床，M走向镜子，D走向门";
		if (Input.GetKeyDown ("b")) {
			state = State.bed_key_cloth;
		} else if (Input.GetKeyDown ("m")) {
			state = State.mirror_key_cloth;
		} else if (Input.GetKeyDown ("d")) {
			state = State.door_key_cloth;
		}
	}

	void state_prison_key_cloth_back ()
	{
		text.text = "对开门仍有一丝犹豫，你又走回了开始的地方。“如果成功的话，就该说再见了。”\n按B走向床，M走向镜子，D走向门";
		if (Input.GetKeyDown ("b")) {
			state = State.bed_key_cloth;
		} else if (Input.GetKeyDown ("m")) {
			state = State.mirror_key_cloth;
		} else if (Input.GetKeyDown ("d")) {
			state = State.door_key_cloth;
		}
	}

	void state_door_nokey ()
	{
		text.text = "监狱的门被锁的死死的，连窗户也没有。你用力拍冰冷的门版，除了很远的地方传来的回音以外听不到任何声音。估计没人可以听到你，这样喊下去也没有用。\n按B返回";
		if (Input.GetKeyDown ("b")) {
			state = State.prison_nokey;
		}

	}

	void state_door_key () 
	{
		text.text = "你拿着玻璃片走到了门前。似乎玻璃片小到可以伸进锁眼。你觉得这是一个尝试的机会。\n按B返回，T尝试开锁";
		if (Input.GetKeyDown ("b")) {
			state = State.prison_key;
		} else if (Input.GetKeyDown ("t")) {
			state = State.door_key_failed;
			tried = 1;
		}

	}

	void state_door_failed ()
	{
		text.text = "你又走回了门边，犹豫了几次还是决定不要冒险。也许还有什么办法！\n按B返回";
		if (Input.GetKeyDown ("b")) {
			state = State.prison_key_failed;
		}
	}

	void state_door_key_failed ()
	{
		text.text = "你小心翼翼地把玻璃片捅进锁眼，但是你发现玻璃片周围太锋利了以至于你没办法用力转动。你看了一眼周围脏脏的环境，决定还是不要弄伤你的手。一旦感染，就算跑出去也没什么用，谁知道外面有什么东西等着你呢？\n按B返回";
		if (Input.GetKeyDown ("b")) {
			state = State.prison_key_failed;
		}
	}

	void state_door_key_cloth ()
	{
		text.text = "你拿着玻璃片和破布走到了门边。门依旧牢牢地被锁住了。\n按B返回，T尝试开门";
		if (Input.GetKeyDown ("b")) {
			state = State.prison_key_cloth_back;
		} else if (Input.GetKeyDown ("t")) {
			state = State.hallway_initial; 
		}
	}

	void state_mirror_nokey ()
	{
		text.text = "“为什么监狱里会有一面镜子？”看到镜子里邋遢的你不禁想。虽然是" +
		"一面镜子，但是已经碎的不成样子了。正当你欣赏自己容貌的同时，" +
		"你注意到地上有一些玻璃片，似乎有些什么用。\n" +
		"按P捡起玻璃片,B走回监狱中间。";
		if (Input.GetKeyDown ("p")) {
			text.text = "你捡起了玻璃片。\n按B返回";
			state = State.mirror_getkey;
		} else if (Input.GetKeyDown ("b")) {
			state = State.prison_nokey;
		}

	}

	void state_mirror_key ()
	{
		text.text = "你拿着玻璃片回到了镜子前。地上还有一些玻璃片，但多拿几个玻璃片并不会有什么帮助，反而可能划伤自己。你看着镜子里的自己，脑子里一片空白。\n按B返回";
		if (Input.GetKeyDown ("b")) {
			state = State.prison_key;
		}
	}

	void state_mirror_key_failed () 
	{
		text.text = "你拿着玻璃片回到了镜子前。地上还有一些玻璃片，但多拿几个玻璃片并不会有什么帮助，反而可能划伤自己。你看着镜子里的自己，脑子里一片空白。\n按B返回";
		if (Input.GetKeyDown ("b")) {
			state = State.prison_key_failed;
		}
	}

	void state_mirror_getkey ()
	{
		if (Input.GetKeyDown ("b")) {
			state = State.prison_key;
		}
	}

	void state_mirror_key_cloth ()
	{
		text.text = "你拿着玻璃片和碎布回到了破了的玻璃前，再次注视着镜子里的自己。你感觉自己马上就要成功了，这种感觉让镜子里的自己看上去没有那么邋遢了。“就这样跑出去吧，愿上帝保佑我。”\n按B返回";
		if (Input.GetKeyDown ("b")) {
			state = State.prison_key_cloth;
		}
	}

	void state_bed_nokey ()
	{
		text.text = "你走到了床边。虽然说是床，实际上只是一块木板上面铺了一层破布。“我这几天都是睡在这里的？”你对前几天的事情已经丝毫没有印象了。就连你是为什么会被关在这里，都没有一点头绪。但现在不是睡觉的时候，你现在只想着赶快逃出去。但是如果已经呆在这里好几天了，为什么不早早逃出去呢？\n按B返回";
		if (Input.GetKeyDown ("b")) {
			state = State.prison_nokey;
		}
	}

	void state_bed_key ()
	{
		if (tried == 0) {
			text.text = "面前还是那张旧床，上面铺着一层破布，是你晚上取暖的唯一途径。“说实话这里的条件还不错，起码还有这些布，比电视剧里面的稻草好多了。”你对自己说。\n按B返回";
			if (Input.GetKeyDown ("b")) {
				state = State.prison_key;
			}
		} else if (tried == 1) {
			text.text = "面前还是那张旧床，上面铺着一层破布，是你晚上取暖的唯一途径。看到布你突然想到了什么。\n按C割下布片，B返回。";
			if (Input.GetKeyDown ("c")) {
				state = State.bed_key_getcloth;
			} else if (Input.GetKeyDown ("b")) {
				state = State.prison_key;
			}
		}
	}

	void state_bed_key_getcloth ()
	{
		text.text = "你拿到了破布。\n按B返回。";
		if (Input.GetKeyDown ("b")) {
			state = State.prison_key_cloth;
		}
	}

	void state_bed_key_cloth ()
	{
		text.text = "你又走回了床边，光秃秃的木板上面还有几只干瘪的虫子。在这个地方如果没有别人的帮助，连虫子都活不下去。估计他们已经有好几天没有给你送饭了。你突然意识到自己肚子里已经空了，一股饥饿感袭来。HP -100\n按B返回";
		if (Input.GetKeyDown ("b")) {
			state = State.prison_key_cloth;
		}
	}

	void state_hallway_initial () 
	{
		text.text = "你成功逃脱！";
	}

}
