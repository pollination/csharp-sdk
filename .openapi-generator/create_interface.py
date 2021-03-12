import os
import sys
import json


# root = os.path.dirname(os.path.dirname(__file__))
# source_folder = os.path.join(root, 'src', lib_Name, 'Model')


def get_package_name():
    config_file = os.path.join(os.getcwd(), '.openapi-generator', '.openapi-config.json')
    with open(config_file, "r") as jsonFile:
        config_data = json.load(jsonFile)

    package_name = config_data["packageName"]
    return package_name


def gen_interfaces(source_json):
    root = os.path.dirname(os.path.dirname(__file__))
    interface_dir = os.path.join(root, 'src', lib_Name, 'Interface')

    with open(source_json, "rb") as jsonFile:
        data = json.load(jsonFile)

    interfaces = {}
    classItems = data['classes']

    for key in classItems.keys():
        name_space = classItems[key].title().replace('_', '', 1)

        if name_space.endswith('_Base'):
            name_space = name_space.replace('_Base', key)

        if name_space not in interfaces:
            interfaces[name_space] = []
        
        if key != '' and not key.startswith('_'):
            interfaces[name_space].append(key)

        # print(f"  |-{data[key]}")
    # print(interfaces)
    create_interfaces(interface_dir, interfaces)


def create_interfaces(dir, interfaces):
    for interface in interfaces:
        space_name = interface
        child_classes = sorted(interfaces[space_name]) 
        create_interface(dir, space_name, child_classes)


def create_interface(dir, space_name, child_classes):

    if space_name == f"{lib_Name}.Model":
        return

    layers = space_name.split('.')
    layers[0] = lib_Name
    sub_folders = layers[1:-1]
    sub_dir = os.path.join(dir, *sub_folders)

    interface_name = layers[-1]
    if interface_name == '_Base':
        return

    space_full_name = ".".join(layers[:-1])


    if not os.path.exists(sub_dir):
        print(f'Creating folder {sub_dir}')
        os.makedirs(sub_dir, exist_ok=True)


    # creating the interface cs file
    interface_file = os.path.join(sub_dir, f'{interface_name}.cs')
    print(f'\nCreating interface {interface_name}: {interface_file}')
    with open(interface_file, "wt", encoding='utf-8') as interfaceFile:
        data = []

        data.append(f'//This is auto generated by create_interface.py\n//Do not edit this manually!.\n')
        data.append(f'namespace {space_full_name}\n')
        data.append('{\n')
        data.append(f'\tpublic partial interface I{interface_name}' + ' {}\n')
        data.append('}\n')
        data.append(f'\n//Classes implemented this interface:\n')

        data.append(f'namespace {layers[0]}\n')
        data.append('{\n')
        for f in child_classes:
            print(f'\t -Adding {f}')
            data.append('\tpublic partial class %s: %s.I%s {}\n' % (f, space_full_name, interface_name))
        data.append('}\n')
        interfaceFile.writelines(data)
        interfaceFile.close()


args = sys.argv[1:]
if args == []:
    raise ValueError("Missing a json path for mapper. eg: python3 create_interface.py \".openapi-docs/simulation-parameter_mapper.json\"")

lib_Name = get_package_name()
json_file = args[0]
gen_interfaces(json_file)
