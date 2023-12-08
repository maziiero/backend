const video = document.querySelector('.video');
const botaoCamera = document.querySelector('.botaoCamera')
const canvas = document.querySelector('.canvas')
const fotoContainer = document.querySelector('.fotos')


const fotos = [];


navigator.mediaDevices.getUserMedia({video : true})
         .then(stream => {
           video.srcObject = stream;
           video.play();
         } )

         botaoCamera.addEventListener('click', () => {
            canvas.getContext('2d').drawImage(video,0,0,
                canvas.width, canvas.height);

                let urlImagem = canvas.toDataURL('image/jpeg');

                const foto = document.createElement('img');
                foto.src = urlImagem;
                foto.className = 'foto';
                fotoContainer.innerHTML= '';
                fotoContainer.appendChild(foto);

                fotos.push(urlImagem);

                foto.addEventListener('click',  ()=> {
                    downloadImagem(urlImagem);

                })
         })

         function downloadImagem(dataUrl){
            const a = document.createElement('a');
            a.href = dataUrl;
            a.download = 'foto.jpg';
            a.style.display = 'none';
            document.body.appendChild(a);
            a.click();
            document.body.removeChild(a);
         }