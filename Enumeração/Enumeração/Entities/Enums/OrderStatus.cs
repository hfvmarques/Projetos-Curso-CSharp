
namespace Enumeração.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
            //Não precisaria enumerar, nesse caso, porque
            //o VS enumera automático a partir do zero
    }
}
