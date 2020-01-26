using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command{
    public abstract void Execute(Animator anim);
}

public class PerformJump: Command {
    public override void Execute(Animator anim) {
        anim.SetTrigger("isJumping");
    }
}

public class DoNothing: Command {
    public override void Execute(Animator anim) {
    
    }
}