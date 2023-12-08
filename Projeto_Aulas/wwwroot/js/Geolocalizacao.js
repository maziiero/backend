if ('geolocation' in navigator){
   navigator.geolocation.getCurrentPosition(function(position){
   var latitude = position.coords.latitude;
   var longitude = position.coords.longitude;

   document.querySelector('#latitude').textContent = latitude;
   document.querySelector('#longitude').textContent = longitude;

   var map = L.map('map').setView([latitude,longitude],15);

   L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
        }).addTo(map);
   })
   L.marker([latitude,longitude]).addTo(map)
   .bindPopup("Sua localização Atual")
   .openPopup();
}
else{
    alert("Geolocalização não é suportada pelo navegador");
}