// 2.��������sw-proxy.js��
self.addEventListener('fetch', async (event) => {
    const { request } = event;
    let response = await fetch(request);
    // 3.���¹���Response
    response = new Response(response.body, response)
    // 4.�۸���Ӧͷ
    response.headers.delete('Content-Security-Policy');
    response.headers.delete('X-Frame-Options');

    event.respondWith(Promise.resolve(originalResponse));
});