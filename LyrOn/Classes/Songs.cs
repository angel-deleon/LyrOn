using System;
using System.Collections.Generic;

namespace LyrOn.Classes
{
    public class Songs
    {

        public List<Song> listSongs { get; private set; }

        public Songs()
        {
            listSongs = new List<Song>();

            // Agregar unas 5 canciones.
            listSongs.Add(
                new Song(
                    "Sorry",
                    "Madonna",
                    "",
                    new Uri("http://ec1.images-amazon.com/images/P/B000B8QEZG.01.MZZZZZZZ.jpg"),
                    @"Sorry

Je suis désolé
Lo siento
Ik ben droevig
Sono spiacente
Perdóname

I've heard it all before
I've heard it all before
I've heard it all before
I've heard it all before
(repeat)

I don't want to hear
I don't want to know
Please don't say you're sorry
I've heard it all before
And I can take care of myself

I don't want to hear
I don't want to know
Please don't say 'forgive me'
I've seen it all before
And I can't take it anymore

You're not half the man you think you are
Save your words because you've gone too far
I've listened to your lies and all your stories
You're not half the man you'd like to be

I don't want to hear
I don't want to know
Please don't say you're sorry
I've heard it all before
And I can take care of myself

I don't want to hear
I don't want to know
Please don't say 'forgive me'
I've seen it all before
And I can't take it anymore

Don't explain yourself cause talk is cheap
There's more important things than hearing you speak
We stayed because I made it so convenient
Don't explain yourself you'll never see

(Sorry in multiple languages)
(Sorry, in english, looped multiple times)

I've heard it all before

I don't want to hear
I don't want to know
Please don't say you're sorry
I've heard it all before
And I can take care of myself

I don't want to hear
I don't want to know
Please don't say 'forgive me'
I've seen it all before
And I can't take it anymore

Don't explain yourself cause talk is cheap
There's more important things than hearing you speak")
            );
            
            listSongs.Add(
                new Song(
                    "Personal Jesus",
                    "Depeche Mode",
                    "",
                    new Uri("http://ec1.images-amazon.com/images/P/B000002LK1.01.MZZZZZZZ.jpg"),
                    @"Reach out and touch faith

Your own personal Jesus
Someone to hear your prayers
Someone who cares
Your own personal Jesus
Someone to hear your prayers
Someone who's there

Feeling unknown
And you're all alone
Flesh and bone
By the telephone
Lift up the receiver
I'll make you a believer

Take second best
Put me to the test
Things on your chest
You need to confess
I will deliver
You know I'm a forgiver

Reach out and touch faith
Reach out and touch faith

Your own personal Jesus
Someone to hear your prayers
Someone who cares
Your own personal Jesus
Someone to hear your prayers
Someone who's there

Feeling unknown
And you're all alone
Flesh and bone
By the telephone
Lift up the receiver
I'll make you a believer
I will deliver
You know I'm a forgiver

Reach out and touch faith

Your own personal Jesus

Reach out and touch faith")
            );

            listSongs.Add(
                new Song(
                    "Whiskey in the Jar",
                    "Metallica",
                    "Garage Inc.",
                    new Uri("http://ec1.images-amazon.com/images/P/B00001ZU5P.09.MZZZZZZZ.jpg"),
                    @"As I was goin' over the Cork and Kerry mountains
I saw Captain Farrell, and his money he was countin'
I first produced my pistol and then produced my rapier
I said, ""Stand and deliver, "" oh, ""or the Devil, he may take ya""

I took all of his money and it was a pretty penny
I took all of his money and I brought it home to Molly
She swore that she'd love me, no, never would she leave me
But the Devil take that woman, for you know she tricked me easy

Mush - a - ring dum a do dum a da
Whack for my daddy-o
Whack for my daddy-o
There's whiskey in the jar-o

Being drunk and weary, I went to Molly's chamber
Takin' my Molly with me, but I never knew the danger
For about six, maybe seven, yeah, in walked Captain Farrell
I jumped up, fired my pistols and I shot him with both barrels

Mush - a - ring dum a do dum a da
Whack for my daddy-o
Whack for my daddy-o
There's whiskey in the jar-o

Yeah, whiskey, oh
Yeah
oh - ho, yeah, oh

Now some men like the fishin' and some man like the foulin'
And some men like ta hear, ta hear cannon ball roarin'
Me I like sleepin', 'specially in my Molly's chamber
But here I am in prison, here I am with a ball and chain, yeah

Mush - a - ring dum a do dum a da
Whack for my daddy-o
Whack for my daddy-o
There's whiskey in the jar-o

Whiskey in the jar - o

Mush - a - ring dum a doo dum a da(x4)"
                )
            );

            listSongs.Add(
                new Song(
                    "Gangsta's Paradise",
                    "Coolio",
                    "Gangsta's Paradise",
                    new Uri("http://images.amazon.com/images/P/B000000HKV.01.MZZZZZZZ.jpg"),
                    @"As I walk through the valley of the shadow of death
I take a look at my life
And realize there's nothing left
'Cause I've been blastin' and laughin' so long that,
even my mama thinks that my mind is gone
But I ain't never crossed a man that didn't deserve it
He'd betreated like a punk, you know that's unheard of
You betta watch how ya talking
And where ya walking
Or you and your homies might be lined in chalk
I really hate to trip but I gotta lope
As they croak, I see myself in the pistol smoke, fool
I'm the kinda g that little homie's wanna be like
On my knees in the night
Saying prayers in the street light

Been spending most our lives
Living in a gangsta's paradise
Been spending most our lives
Living in a gangsta's paradise

Keep spending most our lives
Living in a gangsta's paradise
Keep spending most our lives
Living in a gangsta's paradise

Look at the situation, they got me facing
I can't live a normal life, I was raised by the stripes
So I gotta be down with the hoodteam
Too much television watching, got me chasing dreams
I'm an educated fool with money on my mind
Got my tin in my hand and a gleame in my eye
I'm a loced out gangsta, set trippin banger
And my homies is down so don't arouse my anger, fool
death ain't nothing but a heartbeat away
I'm living my life do a die-er, what can I say?
I'm twenty-three now, but will I live to see twenty-four?
The way things is going I don't know.

Tell me why are we so blind to see
That the ones we hurt are you and me?

Been spending most our lives
Living in a gangsta's paradise
Been spending most our lives
Living in a gangsta's paradise

Keep spending most our lives
Living in a gangsta's paradise
Keep spending most our lives
Living in a gangsta's paradise

Power and the money, money and the power
Minute after minute, hour after hour
Everybody's running, but half of them aint lookin
What's going on in the kitchen?
But I don't know what's cooking.
They say I gotta learn
But nobody's here to teach me
If they can't understand , how can they reach me?
I guess they can't
I guess they won't, I guess they front
That's why I know my life is out of luck, fool!

Been spending most our lives
Living in a gangsta's paradise
Been spending most our lives
Living in a gangsta's paradise

Keep spending most our lives
Living in a gangsta's paradise
Keep spending most our lives
Living in a gangsta's paradise

Tell me why are we, so blind to see
That the ones we hurt, are you and me?
Tell me why are we, so blind to see
That the ones we hurt, are you and me?"
                )
            );

            listSongs.Add(
                new Song(
                    "Shut Up",
                    "The Black Eyed Peas",
                    "Elephunk",
                    new Uri("http://ec2.images-amazon.com/images/P/B0000WN03M.03.MZZZZZZZ.jpg"),
                    @"Shut up
Just shut up
Shut up [3x]
Shut it up, just shut up
Shut up
Just shut up
Shut up [3x]
Shut it up, just shut up, shut up

We're tryin' to take it slow
But we're still losin' control
And we're tryin' to make it work
But it still ends up the worst
And I'm crazy
For tryin' to be your lady
I think I'm goin' crazy

Girl, me and you were just fine you know
We whine and dine
Did them things that couples do when in love you know
Walks on the beach and stuff you know
Things that lovers say and do
I love you boo, I love you too
I miss you a lot, I miss you even more
That's why I flew you out
When we was on tour
But then something got out of hand
You start yellin' when I'm with my friends
Even though I had legitimate reasons
You know I have to make them dividends
How could you trust our private lives girl
That's why you don't believe my lies
And quit this lecture

Shut up, just shut up, shut up
Shut it up, just shut up, shut up

We're tryin' to take it slow
But we're still losin control
And we're tryin' to make it work
But it still ends up the worst
And I'm crazy
For tryin to be your lady
I think I'm goin' crazy

Why does he know she gotta move so fast
Love is progress if you could make it last
Why is it that you just lose control
Every time you agree on takin' it slow
So why does it got to be so damn tough?
Cause fools in lust could never get enough of love
Showin' him the love that you be givin'
Changin' up your livin'
For a lovin' transision
Girl it's a mission tryin' to get you to listen
Few mad at each other has become our tradition
You yell, I yell, everybody yells
Got neighbors across the street sayin'
""Who ? !? ""
Who ?
What's going down?
Too much of the bickering
Kill it with the sound and

Shut up, just shut up, shut up.
Shut it up, just shut up, shut up.

We're tryin' to take it slow
But we're still losin' control
And we're tryin' to make it work
But it still ends up the worst
And I'm crazy
For tryin' to be your lady
I think I'm goin' crazy

Shut up just shut up shut up. [x8]

Girl our love is livin'
Why did you stop tryin'?
I never been a quitah
But I do deserve better
Believe me I will do bad
Let's forget the past
And let's start this new plan
Why? Cause it's the same old routine
And then next week I hear them scream
Girl I know you're tired of the things they say
You're damn right
Cause I heard them lame dame excuses just yesterday
That was a different thing
That was a different thing
That was a different thing
It was the same damn thing
Same ass excuses
Boy you're useless
Woooaaahhh!!!

We're tryin' to take it slow
But we're still losin' control
And we're trying to make it work
But it still ends up the worst
And I'm crazy
For tryin' to be your lady
I think I'm goin' crazy

Stop the talking baby
Or I start walking baby[repeat]
Is that all there is. [repeat till fade]"
                )
            );

        }
    }
}
