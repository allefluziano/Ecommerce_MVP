class Carrinho {
    clickIncremento(btn) {
        let data = this.getData(btn);
        data.Quantidade++;
        this.postQuantidade(data);    
        setTimeout(function () { location.reload() }, 500);
    }

    clickDecremento(btn) {
        let data = this.getData(btn);
        data.Quantidade--;
        this.postQuantidade(data);
        setTimeout(function () { location.reload() }, 500);
    }

    getData(elemento) {
        let linhaDoItem = $(elemento).parents('[item-id]');
        let itemId = parseInt($(linhaDoItem).attr('item-id'));
        let novaQtde = parseInt($(linhaDoItem).find('input').val());

        return {
            Id: itemId,
            Quantidade: novaQtde
        };
    }

    postQuantidade(data) {
        $.ajax({
            url: '/pedido/updatequantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data)
        });
    }
}

var carrinho = new Carrinho();






