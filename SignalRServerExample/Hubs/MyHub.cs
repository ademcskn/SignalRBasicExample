using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRServerExample.Hubs
{
    public class MyHub : Hub
    {
        public async Task SendMessageAsync(string message)
        {
            //bu fonksiyona abone olan clientlarda receiveMessage isimli fonksiyon olması gerekiyor ki tetikleyebilsin ve message adlı mesajı gönderebilsin.
            await Clients.All.SendAsync("receiveMessage", message);

            // 1-asp.net core projesine signalR ile web socket protokolünü kullanmasını söylememiz lazım (Startup.cs)
            // 2-bu huba hangi endpoint de kullanması gerektiğinide söylememiz gerekiyor. (Startup.cs)

            //client tarafında bir index html dosyası açtık ve signalR ı kullanabilmemiz için bir jquery iki npm signalR kütüphanesini projemize dahil etmemiz lazım.
            //terminalden npm i jquery @microsoft/signalr diyoruz.

            //cors ayarlarınıda startup da default olarak gerçekleştirdik.

            //index dosyamızda aynı urlden birden fazla sekmede açıp text'e mesaj yazarsak aynı mesajın diğer sekmelerde(client) gösterildiğini de görmüş oluruz.
        }
    }
}
