class Carrinho {
    reloadPage() {
        setTimeout(function () { location.reload() }, 500);
    }

    clickIncremento(btn) {
        let data = this.getData(btn);
        data.Quantidade++;
        this.postQuantidade(data);
        this.reloadPage();
    }

    clickDecremento(btn) {
        let data = this.getData(btn);
        data.Quantidade--;
        this.postQuantidade(data);
        this.reloadPage();
    }

    updateQuantidade(input) {
        let data = this.getData(input);
        this.postQuantidade(data);
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






