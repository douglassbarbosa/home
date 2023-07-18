import { useEffect, useState } from 'react';
import axios from 'axios';
import { useRouter } from 'next/router';

// Definir o tipo dos objetos dentro do array de clientes
interface Cliente {
    id: any;
    nome: string;
}

export default function ClienteCategoria() {
    const [clientes, setClientes] = useState<Cliente[]>([]); // Definir o tipo de clientes
    const router = useRouter();

    useEffect(() => {
        // Função para carregar os dados da API
        const fetchClientes = async () => {
            try {
                const response = await axios.get('https://localhost:7190/api/CategoriaCliente');
                setClientes(response.data);
            } catch (error) {
                console.error('Erro ao buscar clientes:', error);
            }
        };

        fetchClientes();
    }, []);

    const handleEditCliente = (id: string) => {
        router.push(`/editar-cliente/${id}`);
    };

    const handleDeleteCliente = async (id: string) => {
        try {
            await axios.delete(`https://localhost:7190/api/CategoriaCliente/${id}`);
            // Atualizar a lista de clientes após a exclusão
            const updatedClientes = clientes.filter((cliente) => cliente.id !== id);
            setClientes(updatedClientes);
        } catch (error) {
            console.error('Erro ao excluir cliente:', error);
        }
    };

    return (
        <>
            <h1>Lista de Clientes</h1>
            <ul>
                {clientes.map((cliente) => (
                    <li key={cliente.id}>
                        {cliente.nome}
                        <button onClick={() => handleEditCliente(cliente.id)}>Editar</button>
                        <button onClick={() => handleDeleteCliente(cliente.id)}>Excluir</button>
                    </li>
                ))}
            </ul>
        </>
    );
}
