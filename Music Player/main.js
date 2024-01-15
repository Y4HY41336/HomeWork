const Audios = [
  {
    title: '1',
    artist: '11',
    file: 'musics\FAKELOVE-BTS.mp3',
    image: 'https://imageio.forbes.com/specials-images/imageserve/1207828603/0x0.jpg?format=jpg&height=900&width=1600&fit=bounds'
  },
  {
    title: '2',
    artist: '22',
    file: 'musics\NeverGonnaGiveYouUp.MP3',
    image: 'album-art2.png'
  },
  {
    title: '3',
    artist: '33',
    file: 'musics\toothless-dancing.mp3',
    image: 'album-art3.png'
  }
];

const playButton = document.getElementById('play');
const pauseButton = document.getElementById('pause');
const prevButton = document.getElementById('prev');
const nextButton = document.getElementById('next');

const audio = new Audio('musics\FAKELOVE-BTS.mp3');
let currentAudioIndex = 0;
let isPlaying = false;

function playAudio() {
  const currentAudio = Audios[currentAudioIndex];
  const AudioTitle = document.querySelector('.audio-info h2');
  const AudioArtist = document.querySelector('.audio-info h3');
  const progressBar = document.querySelector('.progress');

  audio.src = currentAudio.file;
  AudioTitle.textContent = currentAudio.title;
  AudioArtist.textContent = currentAudio.artist;
  progressBar.style.width = 0;

  audio.play();
  isPlaying = true;
  playButton.style.display = 'none';
  pauseButton.style.display = 'inline-block';
}

function pauseAudio() {
  audio.pause();
  isPlaying = false;
  playButton.style.display = 'inline-block';
  pauseButton.style.display = 'none';
}

function playNextAudio() {
  currentAudioIndex++;
  if (currentAudioIndex >= Audios.length) {
    currentAudioIndex = 0;
  }
  playAudio();
}

function playPrevAudio() {
  currentAudioIndex--;
  if (currentAudioIndex < 0) {
    currentAudioIndex = Audios.length - 1;
  }
  playAudio();
}

function updateProgressBar() {
  const currentTime = audio.currentTime;
  const duration = audio.duration;
  const progressBar = document.querySelector('.progress');
  const progressPercent = (currentTime / duration) * 100;
  progressBar.style.width = `${progressPercent}%`;

  if (currentTime >= duration && isRepeat) {
    playAudio();
  } else if (currentTime >= duration) {
    pauseAudio();
  }
}



playButton.addEventListener('click', playAudio);
pauseButton.addEventListener('click', pauseAudio);
nextButton.addEventListener('click', playNextAudio);
prevButton.addEventListener('click', playPrevAudio);
repeatButton.addEventListener('click', toggleRepeat);
audio.addEventListener('ended', playNextAudio);
audio.addEventListener('timeupdate', updateProgressBar);
