const CACHE_NAME = 'gymtracker-v1';

// Filer som cachas vid installation så appen fungerar offline
const STATIC_ASSETS = [
    '/',
    '/manifest.json',
    '/app.css',
    '/GymTracker.styles.css'
];

// Installera service worker och cacha statiska filer
self.addEventListener('install', event => {
    event.waitUntil(
        caches.open(CACHE_NAME).then(cache => cache.addAll(STATIC_ASSETS))
    );
    self.skipWaiting();
});

// Ta bort gamla cacher vid uppdatering
self.addEventListener('activate', event => {
    event.waitUntil(
        caches.keys().then(keys =>
            Promise.all(keys.filter(k => k !== CACHE_NAME).map(k => caches.delete(k)))
        )
    );
    self.clients.claim();
});

// Försök hämta från nätverk först, faller tillbaka på cache om offline
self.addEventListener('fetch', event => {
    event.respondWith(
        fetch(event.request)
            .catch(() => caches.match(event.request))
    );
});