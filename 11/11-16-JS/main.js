let audioCtx = new AudioContext();
let oscillator;
oscillator = audioCtx.createOscillator();
oscillator.type = "sine";
oscillator.frequency.value = 440;
oscillator.connect(audioCtx.destination);
oscillator.start(audioCtx.currentTime);
oscillator.stop(audioCtx.currentTime + 0.5);